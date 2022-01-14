﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace xavier_part
{
    public class Product
    {
        string _connStr = ConfigurationManager.ConnectionStrings["product.mdf"].ConnectionString;
        private string _prodID = null;
        private string _prodName = string.Empty;
        private string _prodDesc = ""; // this is another way to specify empty string
        private decimal _unitPrice = 0;
        private string _prodImage = "";
        private int _stockLevel = 0;

        // Default constructor
        public Product()
        {
        }

        // Constructor that take in all data required to build a Product object
        public Product(string prodID, string prodName, string prodDesc,
                       decimal unitPrice, string prodImage, int stockLevel)
        {
            _prodID = prodID;
            _prodName = prodName;
            _prodDesc = prodDesc;
            _unitPrice = unitPrice;
            _prodImage = prodImage;
            _stockLevel = stockLevel;
        }

        // Constructor that take in all except product ID
        public Product(string prodName, string prodDesc,
               decimal unitPrice, string prodImage, int stockLevel)
            : this(null, prodName, prodDesc, unitPrice, prodImage, stockLevel)
        {
        }

        // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
        public Product(string prodID)
            : this(prodID, "", "", 0, "", 0)
        {
        }

        // Get/Set the attributes of the Product object.
        // Note the attribute name (e.g. Product_ID) is same as the actual database field name.
        // This is for ease of referencing.
        public string Product_ID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }
        public string Product_Name
        {
            get { return _prodName; }
            set { _prodName = value; }
        }
        public string Product_Desc
        {
            get { return _prodDesc; }
            set { _prodDesc = value; }
        }
        public decimal Unit_Price
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        public string Product_Image
        {
            get { return _prodImage; }
            set { _prodImage = value; }
        }
        public int Stock_Level
        {
            get { return _stockLevel; }
            set { _stockLevel = value; }
        }
        public int ProductInsert()
        {

            // string msg = null;
            int result = 0;

            string queryStr = "INSERT INTO Products(Product_ID,Product_Name, Product_Desc, Unit_Price,Product_Image,Stock_Level)"
                + " values (@Product_ID,@Product_Name, @Product_Desc, @Unit_Price, @Product_Image,@Stock_Level)";
            //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price, @Product_Image,@Stock_Level)";
            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Product_ID", this.Product_ID);
                cmd.Parameters.AddWithValue("@Product_Name", this.Product_Name);
                cmd.Parameters.AddWithValue("@Product_Desc", this.Product_Desc);
                cmd.Parameters.AddWithValue("@Unit_Price", this.Unit_Price);
                cmd.Parameters.AddWithValue("@Product_Image", this.Product_Image);
                cmd.Parameters.AddWithValue("@Stock_Level", this.Stock_Level);

                conn.Open();
                result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
                conn.Close();

                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }//end Insert
    }
}