using Newtonsoft.Json;

namespace DevBot.Google
{
    public class StepsRequestBody
    {
        public StepsRequestBody(double startTimeMillis, double endTimeMillis, int durationMillis)
        {
            StartTimeMillis = startTimeMillis;
            EndTimeMillis = endTimeMillis;
            AggregateBy = new List<AggregateBy>() { new AggregateBy() };
            BucketByTime = new BucketByTime(durationMillis);
        }

        [JsonProperty("aggregateBy")]
        public List<AggregateBy> AggregateBy { get; set; }

        [JsonProperty("bucketByTime")]
        public BucketByTime BucketByTime { get; set; }

        [JsonProperty("startTimeMillis")]
        public double StartTimeMillis { get; set; }

        [JsonProperty("endTimeMillis")]
        public double EndTimeMillis { get; set; }
    }

    public class AggregateBy
    {
        [JsonProperty("dataTypeName")]
        public string DataTypeName { get; set; } = "com.google.step_count.delta";

        [JsonProperty("dataSourceId")]
        public string DataSourceId { get; set; } = "derived:com.google.step_count.delta:com.google.android.gms:estimated_steps";
    }

    public class BucketByTime
    {
        public BucketByTime(int durationMillis)
        {
            DurationMillis = durationMillis;
        }

        [JsonProperty("durationMillis")]
        public int DurationMillis { get; set; }
    }

}
