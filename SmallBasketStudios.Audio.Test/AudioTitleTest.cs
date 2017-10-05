using System;
using System.Diagnostics;
using SmallBasketStudios.Audio.Data;
using Xunit;
using MongoDB.Driver;
using SmallBasketStudios.Audio.Models;

namespace SmallBasketStudios.Audio.Test
{
    public class AudioTitleTest
    {
        [Fact(DisplayName ="DuplicateTitleCheck")]
        public async void CreateDuplicateTitle()
        {
            AudioTitle title = new AudioTitle();

            title.Title = "AudioAdventure";


            title.Description = "This is just a sample";


          //MongoWriteException mongoEx = await Assert.ThrowsAsync<MongoWriteException>(
          //   () => AudioTitleManager.CreateTitle(title));
             
           //Assert.Equal("E11000 duplicate key error collection: sbsaudio.Title index: TitleIndex dup key: { : \"AudioAdventure\" }", 
           //    mongoEx.WriteError.Message);
            

        }

        [Fact(DisplayName = "CreateTitle")]
        public async void CreateNewTitle()
        {
            AudioTitle title = new AudioTitle();

            title.Title = "AudioAdventure";


            title.Description = "This is just a sample";


          
       //    await AudioTitleManager.CreateTitle(title);
        }


        [Theory(DisplayName = "ValidateTitles")]
        [InlineData("AudioAdventure")]
      
        public async void ValidateTitlesExist(string title)
        {

            AudioTitle foundTitle = null;

         //   foundTitle = await AudioTitleManager.GetTitle(title);

            Assert.NotNull(foundTitle);
        }



    }
    
}
