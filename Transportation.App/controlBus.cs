using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Transportation.Entity;
using Transportation.Repository;
using Transportation.Validation;

namespace Transportation.App
{
    public partial class controlBus : UserControl
    {
        private Bus Bus { get; set; }
        public controlBus()
        {
            InitializeComponent();
        }

        private void controlBus_Load(object sender, EventArgs e)
        {
            this.cmbType.Items.Add("AC");
            this.cmbType.Items.Add("Non AC");
        }
        
        private bool FillEntity()
        {
            this.Bus = new Bus
            {
                BusNo = rtxtPhn.Text,
                TypeId = cmbType.Text,
                NoOfSeats = "45"
            };
            
            BusValidation busValidation = new BusValidation();
            ValidationResult result = busValidation.Validate(this.Bus);
            List<ValidationFailure> failures = result.Errors;
            
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }
        
        private bool UpdateFillEntity()
        {
            this.Bus = new Bus
            {
                BusNo = rtxtPhn.Text,
                TypeId = cmbType.Text,
                NoOfSeats = "45"
            };
            
            BusValidation busValidation = new BusValidation();
            ValidationResult result = busValidation.Validate(this.Bus);
            List<ValidationFailure> failures = result.Errors;
            
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }

        private void ClearBusInput()
        {
            rtxtPhn.Text = "";
            cmbType.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int busIdExist = BusRepo.SearchBusId(this.rtxtPhn.ToString());
            if (busIdExist == 1) //this is for update purpose
            {
                string busNumber = this.Bus.BusNo;
                if (!UpdateFillEntity())
                {
                    return;
                }
                else
                {
                    int checkBusNumberExist = BusRepo.CheckBusNumber(this.Bus.BusNo);

                    if (checkBusNumberExist == 1)
                    {
                        MessageBox.Show("The Bus Number already Exists. Create a New One!");
                    }
                    else
                    {
                        this.Bus.TypeId = BusTypeRepo.GetBusTypeForBus(this.Bus.TypeId);
                        bool updateSignal = BusRepo.Update(this.Bus, busNumber);
                        if (updateSignal)
                        {
                            MessageBox.Show("Bus Updated Successuflly!!");
                            ClearBusInput();
                        }
                    }
                }
            }
            else //this is for insert purpose
            {
                if (!FillEntity())
                {
                    return;
                }
                else if (FillEntity())
                {
                    int checkBusNumberExist = BusRepo.CheckBusNumber(this.Bus.BusNo);

                    if (checkBusNumberExist == 1)
                    {
                        MessageBox.Show("The Bus Number already Exists. Create a New One!");
                    }
                    else
                    {
                        if (this.Bus.TypeId == "Non AC")
                        {
                            this.Bus.TypeId = "NON-AC";
                        }

                        this.Bus.TypeId = BusTypeRepo.GetBusTypeForBus(this.Bus.TypeId);
                        bool insertSignal = BusRepo.Insert(this.Bus);
                        if (insertSignal)
                        {
                            MessageBox.Show("Bus Created Successuflly!!");
                            ClearBusInput();
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBusInput();   
        }
    }
}
