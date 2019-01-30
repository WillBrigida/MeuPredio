using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MeuPredio.DataBase
{
    public class RealmRepository<TRealmObject> where TRealmObject : RealmObject, IEntity
    {
        private readonly Realms.Realm _currentRealm;

        public RealmRepository()
        {
            _currentRealm = Realm.GetInstance();
        }


        public void Insert(TRealmObject item) // 0
        {
            var listaItem = _currentRealm.All<TRealmObject>().ToList(); // 1

            var contadorId = 0; // 2

            if (listaItem.Count != 0) // 3
            {
                contadorId = listaItem.Max(r => r.ID);
            }

            item.ID = contadorId + 1; // 4 

            _currentRealm.Write(() =>  // 5
            _currentRealm.Add(item));

            /*
             * 0 - Objeto genérico que receberá o objeto do banco local.
             * 1 - Lista de itens armazenada no banco local.
             * 2 - Variável contador de IDs iniciada com zero.
             * 3 - Se lista de itens NÃO for zero, então retorna o maior 
             *     valor da lista da propriedade ID e salva na variável contador
             * 4 - ID recebe o valor do contado + 1.
             * 5 - O objeto é salvo no banco local.
            */
        }

   
        public TRealmObject Update(TRealmObject item)
        {
            return _currentRealm.Add(item, true);
        }

        public TRealmObject GetById(long id)
        {
            return _currentRealm.Find<TRealmObject>(id);
        }

        public TRealmObject GetById(string id)
        {
            return _currentRealm.Find<TRealmObject>(id);
        }

        public List<TRealmObject> GetAll()
        {
            return _currentRealm.All<TRealmObject>().ToList();
        }

        public List<TRealmObject> GetAll(Expression<Func<TRealmObject, bool>> predicate)
        {
            return _currentRealm.All<TRealmObject>().Where(predicate).ToList();
        }

        public void Remove(long id)
        {
            var realmItem = GetById(id);
            _currentRealm.Remove(realmItem);
        }

        public void Remove(string id)
        {
            var realmItem = GetById(id);
            _currentRealm.Remove(realmItem);
        }

    }
}
