using Forms9Patch;
using Invoice_Management_System.Views;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Invoice_Management_System.ViewModels
{
    public class LoginVM : INotifyPropertyChanged
    {
        public readonly Forms9Patch.Label labelProperty1 = new Forms9Patch.Label { Text = "Password must contain:", TextColor = Color.Black };
        public readonly Forms9Patch.Label labelProperty2 = new Forms9Patch.Label { Text = "1 capital letter(s)", TextColor = Color.Red };
        public readonly Forms9Patch.Label labelProperty3 = new Forms9Patch.Label { Text = "1 special character", TextColor = Color.Red };
        public readonly Forms9Patch.Label labelProperty4 = new Forms9Patch.Label { Text = "1 numeric character(s)", TextColor = Color.Red };
        public readonly Forms9Patch.Label labelProperty5 = new Forms9Patch.Label { Text = "Password requirements met", TextColor = Color.Green };

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ObservableCollection<SliderImages> slideList = new ObservableCollection<SliderImages>{
                new SliderImages { Image = "Slide2.png" },
                new SliderImages { Image = "Slide4.png" },
                new SliderImages { Image = "Slider3.png" },
                new SliderImages { Image = "Slider4.png" },
                new SliderImages { Image = "Slider1.png" }
            };
        public ObservableCollection<SliderImages> SlideList
        {
            get
            {
                return slideList;
            }
            set
            {
                if (slideList != value)
                {
                    slideList = value;
                    OnPropertyChanged("CartList");
                }
            }
        }
        string _firstName = "";
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }

        string _lastName = "";
        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged();
                }
            }
        }

        string _userName = "";
        public string UserName
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged();
                }
            }
        }

        string _password = "";
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    if ((_password != null) || ((_password != null)))
                    {
                        if (Regex.Match(_password, "[A-Z]+").Success)
                        {
                            labelProperty2.TextColor = Color.Green;
                        }
                        else
                        {
                            labelProperty2.TextColor = Color.Red;
                        }
                        if (Regex.Match(_password, "[0-9]+").Success)
                        {
                            labelProperty4.TextColor = Color.Green;
                        }
                        else
                        {
                            labelProperty4.TextColor = Color.Red;
                        }
                        if (Regex.Match(_password, "(?=.?[#?!@$%^&+-])").Success)
                        {
                            labelProperty3.TextColor = Color.Green;
                        }
                        else
                        {
                            labelProperty3.TextColor = Color.Red;
                        }
                        OnPropertyChanged();
                    }
                }
            }
        }

        string _confirmPassword = "";
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                if (_confirmPassword != value)
                {
                    _confirmPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        string _mobileNum = "";
        public string MobileNumber
        {
            get => _mobileNum;
            set
            {
                if (_mobileNum != value)
                {
                    _mobileNum = value;
                    OnPropertyChanged();
                }
            }
        }

        bool _bubblepopupVisible = false;
        public bool BubblePopupVisible
        {
            get => _bubblepopupVisible;
            set
            {
                if (_bubblepopupVisible != value)
                {
                    _bubblepopupVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        string _pageName = "";
        public string PageName
        {
            get => _pageName;
            set
            {
                if (_pageName != value)
                {
                    _pageName = value;
                    OnPropertyChanged();
                }
            }
        }

        int _selectedCustomer = 0;
        public int SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
