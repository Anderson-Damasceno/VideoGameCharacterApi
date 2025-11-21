using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public class VideoGameCharacterService : IVideoGameCharacterService
{
    public Task<Character> AddCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Character>> GetAllCharactersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Character?> GetCharacterByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCharacterAsync(int id, Character character)
    {
        throw new NotImplementedException();
    }
}
