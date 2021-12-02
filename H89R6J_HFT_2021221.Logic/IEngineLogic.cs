using H89R6J_HFT_2021221.Models;
using System.Collections.Generic;

namespace H89R6J_HFT_2021221.Logic
{
    public interface IEngineLogic
    {
        IEnumerable<KeyValuePair<string, int?>> DieselCostHigherThan4k();
        void Create(Engine engine);
        void Delete(int engineId);
        IEnumerable<Engine> ReadAll();
        Engine ReadOne(int id);
        void Update(Engine engine);
    }
}