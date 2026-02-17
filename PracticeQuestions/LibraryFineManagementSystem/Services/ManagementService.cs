using System.Collections.Generic;
using Domain;
using Exceptions;

namespace Services
{
    public class ManagementService
    {
        private SortedDictionary<int, List<BaseEntity>> _data
            = new SortedDictionary<int, List<BaseEntity>>();

        public void AddEntity(int key, BaseEntity entity)
        {
            // TODO: Validate entity
            entity.Validate();

            // TODO: Handle duplicate entries
            if (_data.ContainsKey(key))
            {
                foreach (var existing in _data[key])
                {
                    if (existing.Id == entity.Id)
                        throw new ScenarioException("Duplicate entity Id");
                }
            }

            // TODO: Add entity to SortedDictionary
            if (!_data.ContainsKey(key))
                _data[key] = new List<BaseEntity>();

            _data[key].Add(entity);
        }

        public void UpdateEntity(int key)
        {
            // TODO: Update entity logic
            if (!_data.ContainsKey(key))
                throw new ScenarioException("Key not found");

            var list = _data[key];

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Validate();
            }
        }

        public void RemoveEntity(int key)
        {
            // TODO: Remove entity logic
            if (!_data.ContainsKey(key))
                throw new ScenarioException("Key not found");

            _data.Remove(key);
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            // TODO: Return sorted entities
            List<BaseEntity> result = new List<BaseEntity>();

            foreach (var pair in _data)
            {
                result.AddRange(pair.Value);
            }

            return result;
        }
    }
}
