using System.Data;

namespace NetCore
{
    public interface IDataProvider
    {
        public DataTable ExecuteQuery(string query, object[] parameter = null);

        public int ExecuteNonQuery(string query, object[] parameter = null);

        public object ExecuteScalar(string query, object[] parameter = null);
    }
}
