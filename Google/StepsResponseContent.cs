using Newtonsoft.Json;

namespace DevBot.Google
{
    public class Bucket
    {
        [JsonProperty("startTimeMillis")]
        public string StartTimeMillis { get; set; }

        [JsonProperty("endTimeMillis")]
        public string EndTimeMillis { get; set; }

        [JsonProperty("dataset")]
        public List<Dataset> Dataset { get; set; }
    }

    public class Dataset
    {
        [JsonProperty("dataSourceId")]
        public string DataSourceId { get; set; }

        [JsonProperty("point")]
        public List<Point> Point { get; set; }
    }

    public class Point
    {
        [JsonProperty("startTimeNanos")]
        public string StartTimeNanos { get; set; }

        [JsonProperty("originDataSourceId")]
        public string OriginDataSourceId { get; set; }

        [JsonProperty("endTimeNanos")]
        public string EndTimeNanos { get; set; }

        [JsonProperty("value")]
        public List<Value> Value { get; set; }

        [JsonProperty("dataTypeName")]
        public string DataTypeName { get; set; }
    }

    public class StepsResponseContent
    {
        [JsonProperty("bucket")]
        public List<Bucket> Bucket { get; set; }
    }

    public class Value
    {
        [JsonProperty("mapVal")]
        public List<object> MapVal { get; set; }

        [JsonProperty("intVal")]
        public int IntVal { get; set; }
    }


}
