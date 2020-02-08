﻿using System.Collections.Generic;

namespace ACM.BL {
    public class Customer {
        public Customer() {

            }

        public Customer(int customerId) {
            CustomerId = customerId;
            }
        public int CustomerId { get; private set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }


        public string FullName {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += ", ";
                        }
                    fullName += FirstName;

                    }

                return fullName;
                }

            }

        public static int InstanceCount { get; set; }

        public bool Validate() {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
            }

        public Customer Retrieve(int CustomerId) {
            //retrieve logic

            return new Customer();
            }

        public List<Customer> Retrieve() {
            //code that retrieves all customers
            return new List<Customer>();
            }

        public bool Save() {
            //save logic
            return true;
            }



        }
    }
