using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Entities;
using Xamarin.Forms;
using XamarinEFCore.DatabaseContext;

namespace XamarinEFCore
{
    public class MainViewModel
    {
        private readonly ApplicationDbContext _db;
        public ICommand AddItemCommand { get; }
        public ICommand RemoveLastCommand { get; }

        public ObservableCollection<ListItem> Items { get; set; }

        public MainViewModel(ApplicationDbContext db)
        {
            _db = db;
            AddItemCommand = new Command(AddItem);
            RemoveLastCommand = new Command(RemoveLast);
            Items = new ObservableCollection<ListItem>(_db.Items.ToList());
        }

        private void AddItem()
        {
            var item = new ListItem
            {
                RandomGuid = Guid.NewGuid().ToString(),
                TimeAdded = DateTime.Now
            };
            _db.Items.Add(item);
            _db.SaveChanges();
            Items.Add(_db.Items.ToList().Last());
        }

        private void RemoveLast()
        {
            var item = Items.LastOrDefault();
            if (item == null) return;
            _db.Items.Remove(item);
            _db.SaveChanges();
            Items.Remove(item);
        }
    }
}