﻿using System;
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
            
            //Now the DataGridView must be filled when this form loads
            this.FillBusDataGridView();
        }
        
        private bool FillEntity()
        {
            this.Bus = new Bus
            {
                BusNo = rtxtPhn.Text,
                TypeId = cmbType.Text,
                NoOfSeats = "37"
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
                NoOfSeats = "37"
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
            //If the clear button is clicked then this means a new Bus is willingly to be created.
            //So, in the following line the bus number will be empty, which indicates the bus will not be for update,
            //rather it is in create mode.
            this.invisibleBusNoText.Text = "";
            rtxtPhn.Text = "";
            cmbType.SelectedIndex = -1;
            this.rtxtPhn.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int busIdExist = BusRepo.SearchBusId(this.rtxtPhn.ToString());
            if (this.invisibleBusNoText.Text != "") //this is for update purpose
            {
                //string busNumber = this.Bus.BusNo;
                if (!UpdateFillEntity())
                {
                    return;
                }
                else
                {
                    UpdateFillEntity();
                    
                    if (this.Bus.TypeId == "Non AC")
                    {
                        this.Bus.TypeId = "NON-AC";
                    }
                        
                    this.Bus.TypeId = BusTypeRepo.GetBusTypeForBus(this.Bus.TypeId);
                    bool updateSignal = BusRepo.Update(this.Bus, this.invisibleBusNoText.Text);
                    if (updateSignal)
                    {
                        MessageBox.Show("Bus Updated Successuflly!!");
                        ClearBusInput();
                        this.invisibleBusNoText.Text = "";
                        this.FillBusDataGridView();
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
                            this.FillBusDataGridView();
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBusInput();
            this.FillBusDataGridView();
        }
        
        private void FillBusDataGridView()
        {
            this.dgvBus.AutoGenerateColumns = false;
            try
            {
                this.dgvBus.DataSource = BusRepo.ShowAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!"+e.Message);
            }
            
            this.dgvBus.ClearSelection();
            this.dgvBus.Refresh();
        }

        private void rtxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvBus.AutoGenerateColumns = false;
            try
            {
                this.dgvBus.DataSource = BusRepo.LiveSearchBus(this.rtxtSearch.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong!"+ exception.Message);
            }
            this.dgvBus.ClearSelection();
            this.dgvBus.Refresh();
        }

        private void dgvBus_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvBus.ClearSelection(); // The column will be unselected in the grid view 
        }
        
        private void dgvRoute_DoubleClick(object sender, EventArgs e)
        {
            this.rtxtPhn.Text = this.dgvBus.CurrentRow.Cells[0].Value.ToString();
            if (this.dgvBus.CurrentRow.Cells[1].Value.ToString() == "NON-AC")
            {
                this.cmbType.Text = "Non AC";
            }

            this.cmbType.Text = this.dgvBus.CurrentRow.Cells[1].Value.ToString();
            this.invisibleBusNoText.Text = this.dgvBus.CurrentRow.Cells[0].Value.ToString();
            this.rtxtPhn.Enabled = false;
        }

        private void deleteBusBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvBus.SelectedRows.Count < 1)
            {
                MessageBox.Show("No data selected");
                return;
            }
            
            if (MessageBox.Show("Are you sure you want to delete?", caption: "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                //MessageBox.Show("hello");
                //when delete button is clicked the bus will be null to route table since it is foreign key
                bool ifBusSetsToNullInRoute = RouteRepo.SetNullToBusNum(this.rtxtPhn.Text);

                if (ifBusSetsToNullInRoute)
                {
                    try
                    {
                        bool ifBusDeleted = BusRepo.Delete(this.rtxtPhn.Text);

                        if (ifBusDeleted)
                        {
                            MessageBox.Show("Deleted Successfully!\nBus associated with routes is inactivated");
                            
                            ClearBusInput();
                            this.invisibleBusNoText.Text = "";
                            this.FillBusDataGridView();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Something went wrong when deleting the bus");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong when setting bus number to null to route\n"+exception);
            }
        }
    }
}
