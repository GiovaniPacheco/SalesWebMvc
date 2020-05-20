﻿using System;

namespace SalesWebMvc.Models.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {

        public NotFoundException(string message) : base(message)
        {
        }



    }
}
