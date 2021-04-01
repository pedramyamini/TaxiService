﻿using Ninject.Infrastructure.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.Models;
using WND.Utility;

namespace WND.Driver
{
    public partial class AddDriver : Form
    {
        private ITaxiDbContext taxiContext;
        Form sourceForm;


        public AddDriver(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            _taxiContext = taxiContext;
        }

        public AddDriver(ITaxiDbContext _taxiContext, Form _sourceForm)
        {
            InitializeComponent();
            taxiContext = _taxiContext;
            sourceForm = _sourceForm;
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                //default SharePercent=0
                int SharePercent = 0;
                int.TryParse(txtSharePercent.Text.PersianToEnglish(), out SharePercent);
                Models.Driver driver = new Models.Driver()
                {
                    FullName = txtFullName.Text,
                    Mobile = txtMobile.Text.PersianToEnglish(),
                    SharePercent = SharePercent,
                    Role = Models.Roles.Driver,
                    Car = new Models.Car()
                    {
                        Color = string.Empty,
                        Model = string.Empty,
                        LicensePlate=string.Empty
                    }
                };
                var conflict = taxiContext.Users.OfType<Models.Driver>();
                if (Validation.Validate(driver))
                {
                    //check fullname and mobile conflict
                    if (!conflict.Any(d => d.FullName == txtFullName.Text && d.Mobile == txtMobile.Text))
                    {
                        //fullname conflict
                        if(conflict.Any(d => d.FullName == txtFullName.Text))
                        {
                            //fullname similarity
                            DialogResult dr=MessageBoxRTL.Ask("راننده با این نام قبلا ثبت شده است. آیا از افزودن این راننده به عنوان یک راننده جدید با تشابه اسمی اطمینان دارید؟", "");
                            if(dr==DialogResult.Yes)
                            {
                                taxiContext.Users.Add(driver);
                                taxiContext.SaveChanges();
                                MessageBoxRTL.Info("راننده با موفقیت افزوده شد.", "");
                            }
                            //edit driver with fullname conflict
                            DialogResult dr2 = MessageBoxRTL.Ask("راننده با این نام قبلا ثبت شده است. آیا مایل به ویرایش این راننده هستید؟", "");
                            if (dr2 == DialogResult.Yes)
                            {
                                Models.Driver driverConflict=conflict.Where(d => d.FullName == txtFullName.Text).Select(d => d).Single();
                                taxiContext.Users.Remove(driverConflict);
                                taxiContext.Users.Add(driver);
                                taxiContext.SaveChanges();
                                MessageBoxRTL.Info("راننده با موفقیت ویرایش شد.", "");
                            }
                        }
                        
                    }
                    else
                    {
                        //edit driver with mobile and fullname conflict
                        DialogResult dr = MessageBoxRTL.Ask("این راننده قبلا ثبت شده است. آیا می‌خواهید آن را ویرایش کنید؟", "");
                        if (dr == DialogResult.Yes)
                        {
                            foreach (var d in conflict.Where(d=>d.FullName==txtFullName.Text && d.Mobile==txtMobile.Text).AsEnumerable())
                            {
                                taxiContext.Users.Attach(d);
                            }
                            taxiContext.Users.Add(driver);
                            taxiContext.SaveChanges();
                            MessageBoxRTL.Info("راننده با موفقیت ویرایش شد.", "");
                        }
                    }
                }
            }
            catch
            {
                MessageBoxRTL.Error("افزودن راننده با خطا مواجه شد لطفا دوباره تلاش کنید", "");
            }
        }

        private void AddDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                sourceForm.Enabled = true;
                sourceForm.Focus();
            }
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
