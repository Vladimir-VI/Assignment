using Assignment.Models;
using System.Linq;
using System.Collections.Generic;
using Assingment.Presentation.Commands;
using System.Windows.Input;
using System.ComponentModel;
using Assignment.Services;
using Assingment.Presentation.DomainModels;
using AutoMapper.QueryableExtensions;

namespace Assingment.Presentation.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ILoadService _loadService;
        private IUpdateService _saveService;
        private RelayCommand _save;
        private object _selectedItem;
        public MainViewModel(ILoadService service, IUpdateService saveService)
        {
            _loadService = service;
            _saveService = saveService;
        }

        public List<EventDomainModel> EventsList => _loadService.Load<Event>()?.ProjectTo<EventDomainModel>().ToList();

        public EventDomainModel PreviousItem { get; set; }

        public EventDomainModel CurrentItem { get; set; }
        public object SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                this.OnPropertyChanged(nameof(SelectedItem));
                this.ChangeSelection();
            }
        }

        public int SelectedIndex { get; set; }

        public ICommand Save
        {
            get
            {
                if (_save == null)
                {
                    _save = new RelayCommand((obj) =>
                    {
                        var test = this.EventsList;
                        var item = this.SelectedItem as EventDomainModel;
                        var temp = new Event
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Description = item.Description,
                            FromDate = item.FromDate,
                            ToDate = item.ToDate,
                            Status = item.Status
                        };
                        _saveService.Update<Event>(temp);
                        this.CurrentItem.Changed = true;
                    });

                }
                return _save;
            }
        }

        //Reverts the model to it's previous state if changes are not saved
        public void ChangeSelection()
        {
            if (this.CurrentItem != null && !this.CurrentItem.Changed && this.PreviousItem != null)
            {
                this.CurrentItem.ShallowCopy(this.PreviousItem);
            }
            if (this.CurrentItem != null)
                this.CurrentItem.Changed = false;
            this.PreviousItem = (this.SelectedItem as EventDomainModel)?.DeepCopy();
            this.CurrentItem = SelectedItem as EventDomainModel;
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

