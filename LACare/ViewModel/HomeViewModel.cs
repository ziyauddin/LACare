using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LACare
{
    public class HomeViewModel : ViewModelBase
    {
        /// <summary>
        /// The listofdates
        /// </summary>
        private ObservableCollection<DateTime> _listofdates;

        /// <summary>
        /// The date
        /// </summary>
        private DateTime date;

        /// <summary>
        /// Gets and Sets ListofDates 
        /// </summary>
        /// <value>
        /// The listofdates
        /// </value>
        public ObservableCollection<DateTime> ListofDates
        {
            get { return _listofdates; }
            set
            {
                if (_listofdates != value)
                {
                    _listofdates = value;
                    OnPropertyChanged("ListofDates");
                }
            }
        }

        /// <summary>
        /// Gets and Sets Date 
        /// </summary>
        /// <value>
        /// The date
        /// </value>
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        /// <summary>
        /// The Previous Command
        /// </summary>
        public Command PreviousCommand { get; private set; }

        /// <summary>
        /// The Next Command
        /// </summary>
        public Command NextCommand { get; private set; }
        public Command SelectDateCommand { get; private set; }
        private void HandleItemSelected(DateTime selectedItem)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel" /> class.
        /// </summary>
        public HomeViewModel()
        {
            DateTime StartingDate = DateTime.Parse("04/01/2018");
            DateTime EndingDate = DateTime.Parse("06/30/2018");

            ListofDates = GetDateRange(StartingDate, EndingDate);
            Date = ListofDates[0].Date;
            PreviousCommand = new Command(() =>
           {
               PreviousDateExecute();
           });
            NextCommand = new Command(() =>
            {
                NextDateExecute();
            });
            SelectDateCommand = new Command(SelectedDate);
        }

        private void SelectedDate(object obj)
        {
            DateTime _date = (DateTime)(obj);
            var Index = ListofDates.IndexOf(_date.Date);
            Date = ListofDates[Index].Date;
        }

        /// <summary>
        /// Get Previous date 
        /// </summary>
        public async void PreviousDateExecute()
        {
            if (ListofDates.IndexOf(Date)!=0)
            {
                Date = ListofDates[ListofDates.IndexOf(Date) - 1].Date;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Alert!", "Minimum date", "Ok");               
            }
          
        }

        /// <summary>
        /// Get Next date 
        /// </summary>
        public async void NextDateExecute()
        {
            if (ListofDates.IndexOf(Date) < ListofDates.Count - 1)
            {
                Date = ListofDates[ListofDates.IndexOf(Date) + 1].Date;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Alert!", "Maximum date", "Ok");
            }
        }

        /// <summary>
        /// Get Date range
        /// </summary>
        /// <param name="StartingDate"> The Starting Date</param>
        /// <param name="EndingDate">The Ending Date</param>
        /// <returns></returns>
        private ObservableCollection<DateTime> GetDateRange(DateTime StartingDate, DateTime EndingDate)
        {
            if (StartingDate > EndingDate)
            {
                return null;
            }
            ObservableCollection<DateTime> rv = new ObservableCollection<DateTime>();
            DateTime tmpDate = StartingDate;
            do
            {
                rv.Add(tmpDate);
                tmpDate = tmpDate.AddDays(1);
            } while (tmpDate <= EndingDate);
            return rv;
        }
    }
}
