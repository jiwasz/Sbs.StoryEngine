using System;
using System.Diagnostics;
using SmallBasketStudios.Audio.Data;
using SmallBasketStudios.Audio.Repository.Models;
using Xunit;
using MongoDB.Driver;


namespace SmallBasketStudios.Audio.Test
{
    public class AudioTitleTest
    {
        [Fact]
        public async void CreateDuplicateTitle()
        {
            AudioTitle title = new AudioTitle();

            title.Title = "AudioAdventure";


            title.Description = "This is just a sample";


          MongoWriteException mongoEx = await Assert.ThrowsAsync<MongoWriteException>(
             () => AudioTitleManager.CreateTitle(title));
             
           Assert.Equal("E11000 duplicate key error collection: sbsaudio.Title index: TitleIndex dup key: { : \"AudioAdventure\" }", 
               mongoEx.WriteError.Message);
            

        }

        [Fact]
        public async void CreateNewTitle()
        {
            AudioTitle title = new AudioTitle();

            title.Title = "AudioAdventure";


            title.Description = "This is just a sample";


          
           await AudioTitleManager.CreateTitle(title);
        }


        [Theory]
        [InlineData("AudioAdventure")]
      
        public async void ValidateTitlesExist(string title)
        {

            AudioTitle foundTitle = null;

            foundTitle = await AudioTitleManager.GetTitle(title);

            Assert.NotNull(foundTitle);
        }



    }
    
}
