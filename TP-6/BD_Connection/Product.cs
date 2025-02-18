using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Represents a product in the system.
/// </summary>
public class Product
{
    /// <summary>
    /// Unique identifier of the product.
    /// </summary>
    private int ID;

    /// <summary>
    /// Name of the product.
    /// </summary>
    private string Name;

    /// <summary>
    /// Supplier identifier of the product.
    /// </summary>
    private int Supplier_ID;

    /// <summary>
    /// Category identifier of the product.
    /// </summary>
    private int Category_ID;

    /// <summary>
    /// Quantity of units per stock.
    /// </summary>
    private string StockXUnits;

    /// <summary>
    /// Unit price of the product.
    /// </summary>
    private decimal UnitPrice;

    /// <summary>
    /// Quantity of units in stock.
    /// </summary>
    private int UnitInStock;

    /// <summary>
    /// Quantity of units on order.
    /// </summary>
    private int UnitsInIrder;

    /// <summary>
    /// State of the product (active/inactive).
    /// </summary>
    private bool state;

    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class.
    /// </summary>
    /// <param name="iD">Unique identifier of the product.</param>
    /// <param name="name">Name of the product.</param>
    /// <param name="supplier_ID">Supplier identifier of the product.</param>
    /// <param name="category_ID">Category identifier of the product.</param>
    /// <param name="stockXUnits">Quantity of units per stock.</param>
    /// <param name="unitPrice">Unit price of the product.</param>
    /// <param name="unitInStock">Quantity of units in stock.</param>
    /// <param name="unitsInIrder">Quantity of units on order.</param>
    /// <param name="state">State of the product (active/inactive).</param>
    public Product(
        int iD = 0,
        string name = "",
        int supplier_ID = 0,
        int category_ID = 0,
        string stockXUnits = "",
        decimal unitPrice = 0,
        int unitInStock = 0,
        int unitsInIrder = 0,
        bool state = true)
    {
        ID = iD;
        Name = name;
        Supplier_ID = supplier_ID;
        Category_ID = category_ID;
        StockXUnits = stockXUnits;
        UnitPrice = unitPrice;
        UnitInStock = unitInStock;
        UnitsInIrder = unitsInIrder;
        this.state = state;
    }

    /// <summary>
    /// Gets or sets the unique identifier of the product.
    /// </summary>
    public int ID1 { get => ID; set => ID = value; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    public string Name1 { get => Name; set => Name = value; }

    /// <summary>
    /// Gets or sets the supplier identifier of the product.
    /// </summary>
    public int Supplier_ID1 { get => Supplier_ID; set => Supplier_ID = value; }

    /// <summary>
    /// Gets or sets the category identifier of the product.
    /// </summary>
    public int Category_ID1 { get => Category_ID; set => Category_ID = value; }

    /// <summary>
    /// Gets or sets the quantity of units per stock.
    /// </summary>
    public string StockXUnits1 { get => StockXUnits; set => StockXUnits = value; }

    /// <summary>
    /// Gets or sets the unit price of the product.
    /// </summary>
    public decimal UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }

    /// <summary>
    /// Gets or sets the quantity of units in stock.
    /// </summary>
    public int UnitInStock1 { get => UnitInStock; set => UnitInStock = value; }

    /// <summary>
    /// Gets or sets the quantity of units on order.
    /// </summary>
    public int UnitsInIrder1 { get => UnitsInIrder; set => UnitsInIrder = value; }

    /// <summary>
    /// Gets or sets the state of the product (active/inactive).
    /// </summary>
    public bool State { get => state; set => state = value; }
}
