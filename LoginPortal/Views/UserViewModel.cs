using LoginPortal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPortal.Views
{
    class UserViewModel
    {
        private ObservableCollection<User> _users => new ObservableCollection<User>()
        {
            new User("Joe", "Dane"),
            new User("Tim", "Banks"),
            new User("Fred", "Schneider"),
            new User("Kim", "Byers"),
            new User("Scott", "Cambell")
        };

        public ObservableCollection<User> Users => _users;
    }
}
