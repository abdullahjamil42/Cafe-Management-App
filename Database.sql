CREATE TABLE SystemUser (
  U_id INT PRIMARY KEY IDENTITY(1,1), -- Auto-increment primary key
  U_name VARCHAR(50),
  U_email VARCHAR(50) UNIQUE,
  U_password VARCHAR(255),
  U_role VARCHAR(50)
);

CREATE TABLE Admins (
  admin_id INT PRIMARY KEY ,  
  Authority VARCHAR(50)
);

CREATE TABLE Worker (
  worker_id INT PRIMARY KEY , 
  Schedule VARCHAR(50),
  W_permissions VARCHAR(50)
);
 
CREATE TABLE Customer (
  customer_id INT PRIMARY KEY  ,
  no_of_orders INT,
);

CREATE TABLE Menuitem (
  PK_menuitem_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),  
  mn_name VARCHAR(255) NOT NULL,
  mn_price DECIMAL(10,2) NOT NULL,
  mn_description VARCHAR(255),
  m_Availability VARCHAR(20),
  Category VARCHAR(20)
  Picture VARBINARY(MAX);
);

CREATE TABLE Inventory (
  PK_inventory_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),  
  FK_menultem_id INT,
  Quantity INT NOT NULL,
  inventory_item_name VARCHAR(255) NOT NULL,
  FOREIGN KEY (FK_menultem_id) REFERENCES Menuitem(PK_menuitem_id) ON DELETE SET NULL
);

CREATE TABLE Cart (
  PK_Cart_id INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
  FK_customer_id INT,
  FOREIGN KEY (FK_customer_id) REFERENCES Customer(customer_id) ON DELETE SET NULL
);

CREATE TABLE Orders (
  Order_id INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
  order_date DATETIME NOT NULL,
  order_status VARCHAR(20) NOT NULL,
  Order_amount DECIMAL(10,2) NOT NULL,
  FK_Customer_id INT,
  FK_Worker_id INT,
  FK_CartID int,
  order_note VARCHAR(255),
  FOREIGN KEY (FK_CartID) REFERENCES Cart(PK_Cart_id) ON DELETE SET NULL,
  FOREIGN KEY (FK_Customer_id) REFERENCES Customer(customer_id) ON DELETE SET NULL,
  FOREIGN KEY (FK_Worker_id) REFERENCES Worker(worker_id) ON DELETE SET NULL
);


CREATE TABLE Cartitem (
  PK_cartitem_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),  
  FK_cart_id INT,
  FK_menultem_id INT,
  Quantity int,
  FOREIGN KEY (FK_cart_id) REFERENCES Cart(PK_Cart_id) ON DELETE SET NULL,
  FOREIGN KEY (FK_menultem_id) REFERENCES Menuitem(PK_menuitem_id) ON DELETE SET NULL
);

CREATE TABLE Orderitem (
  PK_orderitem_id INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
  FK_order_id INT,
  FK_menuitem_id INT,
  FOREIGN KEY (FK_order_id) REFERENCES Orders(Order_id) ON DELETE SET NULL,
  FOREIGN KEY (FK_menuitem_id) REFERENCES Menuitem(PK_menuitem_id) ON DELETE SET NULL
);

CREATE TABLE Feedback (
  Feedback_id INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
  customer_id INT,
  order_id INT,
  Feedback_date DATETIME NOT NULL,
  Feedback_rating INT NOT NULL,
  Feedback VARCHAR(255),
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id) ON DELETE SET NULL,
  FOREIGN KEY (order_id) REFERENCES Orders(Order_id) ON DELETE SET NULL
);

CREATE TABLE Payment (
  payment_id INT PRIMARY KEY IDENTITY(1,1), 
  order_id INT,
  customer_id INT,
  amount DECIMAL(10, 2),
  payment_method VARCHAR(20),
  payment_date DATE,
  p_status VARCHAR(20),
  FOREIGN KEY (order_id) REFERENCES Orders(Order_id) ON DELETE SET NULL,
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id) ON DELETE SET NULL
);

CREATE TABLE AdminInventory (
  admin_id INT,
  inventory_id INT,
  PRIMARY KEY (admin_id, inventory_id),
  FOREIGN KEY (admin_id) REFERENCES Admins(admin_id) ON delete Cascade,
  FOREIGN KEY (inventory_id) REFERENCES Inventory(PK_inventory_id) ON delete  Cascade
);

CREATE TABLE WorkerOrder (
  worker_id INT,
  order_id INT,
  PRIMARY KEY (worker_id, order_id),
  FOREIGN KEY (worker_id) REFERENCES Worker(worker_id) ON DELETE CASCADE,
  FOREIGN KEY (order_id) REFERENCES Orders(Order_id) ON DELETE CASCADE
);

CREATE TABLE AdminWorker (
  admin_id INT,
  worker_id INT,
  PRIMARY KEY (admin_id, worker_id),
  FOREIGN KEY (admin_id) REFERENCES Admins(admin_id) ON DELETE CASCADE,
  FOREIGN KEY (worker_id) REFERENCES Worker(worker_id) ON DELETE CASCADE
);

CREATE TABLE MenuitemOrderitem (
  menuitem_id INT,
  orderitem_id INT,
  PRIMARY KEY (menuitem_id, orderitem_id),
  FOREIGN KEY (menuitem_id) REFERENCES Menuitem(PK_menuitem_id) ON DELETE CASCADE,
  FOREIGN KEY (orderitem_id) REFERENCES Orderitem(PK_orderitem_id) ON DELETE CASCADE
);

------triggers

CREATE TRIGGER IncrementNoOfOrders
ON Orders
AFTER INSERT
AS
BEGIN
    -- Update the no_of_orders column in the Customer table
    UPDATE Customer
    SET no_of_orders = no_of_orders + 1
    WHERE customer_id IN (SELECT FK_Customer_id FROM inserted);
END;


--2 insert into subclasses when systemuser has insertion
create trigger InsertIntoSubclass
on SystemUser
after insert
as
begin
    
    declare @U_id int, @U_role varchar(50);
    
  
    select @U_id = i.U_id, @U_role = i.U_role
    from inserted i;
    
  
    IF @U_role = 'Admin'
    begin
 --Admins table
         insert into Admins (admin_id, Authority)
        VALUES (@U_id, 'Full'); 
    END
    else if @U_role = 'Customer'
    begin
--Customer table
        insert into Customer (customer_id, no_of_orders)
        values (@U_id, 0); 
    end
    else if @U_role = 'Worker'
    begin
--Worker table
       insert into Worker (worker_id, Schedule, W_permissions)
        values (@U_id, 'Day Shift', 'General'); 
    end

end;


