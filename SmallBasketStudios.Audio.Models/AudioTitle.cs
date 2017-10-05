using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SmallBasketStudios.Audio.Models;

namespace SmallBasketStudios.Audio.Models
{
    public class AudioTitle : IAudioEntity
    {

        /// <summary>
        /// Collection id of the audio skill.
        /// </summary>
        //  public ObjectId Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }


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
        [BsonIgnoreIfNull(true)]
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
        [BsonIgnoreIfNull(true)]
        [BsonElement("skillid")]
        public string SkillId { get; set; }
    }
}
