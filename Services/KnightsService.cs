using System;
using kingdom.Models;


namespace kingdom.Services
{
  public class KnightsService
  {
      private readonly KnightsRepository _repo;
      public KnightsService(KnightsRepository repo)
      {
          _repo = repo;
      }    
      internal IEnumberable<Knight> Get()
    {
        return _repo.Get();
    }

    internal Knight Get(int id)
    {
        Knight knight = _repo.Get(id);
        if (knight == null)
        {
            throw new Exception("Invalid Id");
        }
        return knight;
    }

    internal Knight Create(Knight newKnight)
    {
        Knight knight = _repo.Create(newKnight);
        if (knight == null)
        {
            throw new Exception("Invalid Id")
        }
        return knight;
    }

    internal Knight Edit(Knight updatedKnight)
    {
      Knight original = Get(updatedKnight.Id);
      updatedKnight.Name = updatedKnight.Name != null ? updatedKnight.Name : original.Name;
      updatedKnight.Mission = updatedKnight.Mission != null ? updatedKnight.Mission : original.Mission;
      updatedKnight.CastleId = updatedKnight.CastleId != null ? updatedKnight.CastleId : original.CastleId;
      return _repo.Update(updatedKnight)
    }

    internal void Delete(int id)
    {
      Knight original = Get(id);
      _repo.Delete(id);
    }
  }
}