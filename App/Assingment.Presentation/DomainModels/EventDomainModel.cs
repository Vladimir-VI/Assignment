using Assignment.Models.Enums;
using System;
using System.ComponentModel;

namespace Assingment.Presentation.DomainModels
{
    public class EventDomainModel : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private DateTime _fromDate;
        private DateTime _toDate;
        private Status _status;
        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                this.OnPropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                this.OnPropertyChanged(nameof(Description));
            }
        }

        public DateTime FromDate
        {
            get => _fromDate;
            set
            {
                _fromDate = value;
                this.OnPropertyChanged(nameof(FromDate));
            }
        }

        public DateTime ToDate
        {
            get => _toDate;
            set
            {
                _toDate = value;
                this.OnPropertyChanged(nameof(ToDate));
            }
        }

        public Status Status
        {
            get => _status;
            set
            {
                _status = value;
                this.OnPropertyChanged(nameof(Status));
            }
        }

        public EventDomainModel DeepCopy()
        {
            return new EventDomainModel()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                FromDate = this.FromDate,
                ToDate = this.ToDate,
                Status = this.Status
            };
        }

        public void ShallowCopy(EventDomainModel source)
        {
            this.Id = source.Id;
            this.Name = source.Name;
            this.Description = source.Description;
            this.FromDate = source.FromDate;
            this.ToDate = source.ToDate;
            this.Status = source.Status;
        }

        public bool Changed { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
