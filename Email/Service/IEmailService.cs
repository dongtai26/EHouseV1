﻿using Email.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Service
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
