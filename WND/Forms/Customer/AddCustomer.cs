using BaseFormLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using Utility;

namespace WND.Forms.Customer
{
    public partial class AddCustomer : BaseForm
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Models.Customer customer = new Models.Customer()
            {
                FullName=txtFullName.Text,
                Mobile=txtMobile.Text.PersianToEnglish(),
                Address=txtAddress.Text,
                Role=Models.Roles.Customer
            };
            if (Validation.Validate(customer))
            {
                try
                {
                    var Customers = TaxiDbContext.Instance.Users.OfType<Models.Customer>();
                    if (Customers.Any(c => c.FullName == customer.FullName && c.Mobile != customer.Mobile))
                    {
                        //fullname conflict. create customer or not?
                        DialogResult dr = MessageBoxRTL.Ask($"مشتری با نام { customer.FullName } قبلا ثبت شده است. آیا می‌خواهید مشتری جدیدی با تشابه اسمی را ثبت نمایید؟", string.Empty);
                        if (dr == DialogResult.Yes)
                        {
                            TaxiDbContext.Instance.Users.Add(customer);
                            TaxiDbContext.Instance.SaveChanges();
                            MessageBoxRTL.Info($"ثبت اشتراک {customer.FullName} با موفقیت انجام شد.", "");
                        }

                        //update existing customer
                        dr = MessageBoxRTL.Ask($"مشتری با نام { customer.FullName } قبلا ثبت شده است. آیا می‌خواهید مشتری قبلی را ویرایش نمایید؟", string.Empty);
                        if (dr == DialogResult.Yes)
                        {
                            var conflictCustomer = Customers.Where(c => c.FullName == customer.FullName).Single();
                            TaxiDbContext.Instance.Users.Remove(conflictCustomer);
                            TaxiDbContext.Instance.Users.Add(customer);
                            TaxiDbContext.Instance.SaveChanges();
                            MessageBoxRTL.Info($"ویرایش اشتراک {customer.FullName} با موفقیت انجام شد.", "");
                        }
                    }
                    //mobile conflict. Update or not?
                    else if(Customers.Any(c=>c.Mobile==customer.Mobile && c.FullName!=customer.FullName))
                    {
                        DialogResult dr = MessageBoxRTL.Ask($"مشتری با شماره همراه { customer.Mobile } قبلا ثبت شده است. آیا می‌خواهید مشتری قبلی را ویرایش نمایید؟", string.Empty);
                        if (dr == DialogResult.Yes)
                        {
                            var conflictCustomer = Customers.Where(c => c.Mobile == customer.Mobile).Single();
                            TaxiDbContext.Instance.Users.Remove(conflictCustomer);
                            TaxiDbContext.Instance.Users.Add(customer);
                            TaxiDbContext.Instance.SaveChanges();
                            MessageBoxRTL.Info($"ویرایش اشتراک {customer.FullName} با موفقیت انجام شد.", "");
                        }
                    }
                    //this exact customer already exists. avoid db transaction
                    else if(Customers.Any(c => c.Mobile == customer.Mobile && c.FullName == customer.FullName && c.Address==customer.Address))
                    {
                        MessageBoxRTL.Error("مشتری با مشخصات واردشده قبلا ثبت شده است.", string.Empty);
                    }
                    //change only existing customer address 
                    else if(Customers.Any(c => c.Mobile == customer.Mobile && c.FullName == customer.FullName && c.Address != customer.Address))
                    {
                        DialogResult dr=MessageBoxRTL.Ask("مشتری با مشخصات واردشده قبلا ثبت شده است. آیا مایل به ویرایش نشانی مشتری هستید؟", string.Empty);
                        if(dr==DialogResult.Yes)
                        {
                            Customers.Where(c => c.Mobile == customer.Mobile && c.FullName == customer.FullName && c.Address != customer.Address)
                                .Single().Address = customer.Address;
                            TaxiDbContext.Instance.SaveChanges();
                        }
                    }
                    //new customer
                    else
                    {
                        TaxiDbContext.Instance.Users.Add(customer);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info("افزودن مشتری با موفقیت انجام شد.", string.Empty);
                    }
                    
                }
                catch(DbUpdateException ex)
                {
                    if (ex != null)
                    {
                        MessageBoxRTL.Error("شماره همراه نمی‌تواند تکراری باشد", "");
                    }
                    else
                    { 
                        MessageBoxRTL.Error($"ثبت اشتراک {customer.FullName} با خطا روبرو شد لطفا مجددا تلاش نمایید.", "");
                    }
                }
            }
        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
