using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SmallBasketStudios.Audio.Models;

namespace SmallBasketStudios.Audio.Data
{
    public interface ITitleRepository
    {
       Task CreateTitle(AudioTitle title);

        Task<AudioTitle> GetByTitle(string title);

        Task<AudioTitle> GetBySkillId(string skillId);
    }
}
