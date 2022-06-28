using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CoursesApi.Domain
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; } = String.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = String.Empty;

        [BsonElement("category")]
        public string Category { get; set; } = String.Empty;

        [BsonElement("positionInCategory")]
        public int PositionInCategory { get; set; }

        [BsonElement("numberOfDays")]
        public int NumberOfDays { get; set; }

        

    }
}
