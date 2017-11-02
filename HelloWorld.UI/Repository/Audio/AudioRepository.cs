namespace HelloWord.Core.Repository.Audio.Impl.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model.Audio;

    public class AudioRepository: IAudioRepository
    {
        public Task<IEnumerable<Audio>> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Task<Audio> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Audio entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Audio entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Audio entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}