using System.Data;

namespace Net60
{
    public interface IDataProvider
    {
        public DataTable ExecuteQuery(string query, object[]? parameter = null);

        public int ExecuteNonQuery(string query, object[]? parameter = null);

        public object ExecuteScalar(string query, object[]? parameter = null);
    }
}
