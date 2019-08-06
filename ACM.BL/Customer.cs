﻿using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Customer: EntityBase, ILoggable
    {
        public Customer(): this(0)
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> AddressList { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }
        
        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        
        public override string ToString() => FullName;
        
        // Validates user LastName and EmailAddress
        public override bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}