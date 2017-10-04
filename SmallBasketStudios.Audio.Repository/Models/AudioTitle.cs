using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SmallBasketStudios.Audio.Repository.Models
{
    public class AudioTitle
    {

        /// <summary>
        /// Collection id of the audio skill.
        /// </summary>
        public ObjectId Id { get; set; }


        /// <summary>
        /// Public title of the audio skill.
        /// </summary>
        [BsonRequired]
        [BsonElement("title")]
        public string Title { get; set; }


        /// <summary>
        /// Date the audio skill was pubished. If it has not yet been published, the date is null.
        /// </summary>
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        [BsonElement("publishdate")]

        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// Summary of the skill.
        /// </summary>        
        [BsonRepresentation(BsonType.String)]
        [BsonElement("description")]
        public string Description { get; set; }


        /// <summary>
        /// Alexa skill id related to this title.
        /// </summary>
        [BsonRepresentation(BsonType.String)]
        [BsonElement("skillid")]
        public string SkillId { get; set; }

    }
}
