using Common;
using Repository.DBConnection;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class GenericDBRepository : IDBRepository<IEntity>
    {
        public void Close()
        {
            DbConnectionFactory.Instance.GetDbConnection().Close();
        }

        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }

        public object Add(IEntity entity)
        {
            string command = $"insert into {entity.TableName} output {entity.Output} values {entity.InsertValues}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            return cmd.ExecuteScalar();

        }

        public void Delete(IEntity entity, string criteria)
        {
            string command = $"delete from {entity.TableName}";
            command += $" where {criteria}";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows update: " + x);

        }

        public IEntity Get(IEntity entity, string criteria)
        {
            string komanda = $"select * from {entity.TableName} ";
            komanda += $" {entity.Join}";
            komanda += $" where {criteria} ";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);


            var reader = cmd.ExecuteReader();
            List<IEntity> lista = entity.GetList(reader);

            reader.Close();
            if (lista.Count > 0) return lista[0];
            return null;

        }

        public List<IEntity> GetAll(IEntity entity)
        {
            string command = $"select * from {entity.TableName}";
            command += " " + entity.Join;

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            var reader = cmd.ExecuteReader();
            List<IEntity> list = entity.GetList(reader);
            reader.Close();

            if (list == null) throw new Exception("Greska");
            return list;
        }

        public List<IEntity> Search(IEntity entity, string criteria)
        {
            string komanda = $"select * from {entity.TableName} {entity.Join} where {criteria}";
            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(komanda);
            var reader = cmd.ExecuteReader();
            List<IEntity> lista = entity.GetList(reader);

            reader.Close();
            return lista;
        }


        public void Update(IEntity entity, string criteria)
        {
            string command = $"update {entity.TableName} set {entity.UpdateValues}";

            command += $"where {criteria}";

            SqlCommand cmd = DbConnectionFactory.Instance.GetDbConnection().CreateCommand(command);
            int x = cmd.ExecuteNonQuery();

            Console.WriteLine("Affected rows update: " + x);

        }


    }
}
