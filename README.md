# Shipment_Project

## Setup Instructions

1. Clone the repository.
2. Open the `appsettings.json` file.
3. Edit the connection string with your new database information.
   "ConnectionStrings": {
     "DefaultConnection": "Server=mynewserver;Database=mynewdatabase;Trusted_Connection=True;"
   }
4. Save the changes to the `appsettings.json` file.
6. Run update-database command in Package manager console.
5. Build and run the application.


## For add Dummy data to database
Execute these query into database.


-- Insert data into dbo.SHIPPER
INSERT INTO dbo.SHIPPER (shipper_name) VALUES ('Blossom Manufacturing')
INSERT INTO dbo.SHIPPER (shipper_name) VALUES ('Sporting Partners')
INSERT INTO dbo.SHIPPER (shipper_name) VALUES ('Associates and Company')

-- Insert data into dbo.CARRIER
INSERT INTO dbo.CARRIER (carrier_name, carrier_mode) VALUES ('Short Line RailRoad', 'RAIL')
INSERT INTO dbo.CARRIER (carrier_name, carrier_mode) VALUES ('Planet Express', 'TRUCK')
INSERT INTO dbo.CARRIER (carrier_name, carrier_mode) VALUES ('Greene Transport', 'TRUCK')
INSERT INTO dbo.CARRIER (carrier_name, carrier_mode) VALUES ('Big Boats R Us', 'OCEAN')
INSERT INTO dbo.CARRIER (carrier_name, carrier_mode) VALUES ('Speedy Delivery', 'TRUCK')

-- Insert data into dbo.SHIPMENT_RATE
INSERT INTO dbo.SHIPMENT_RATE (shipment_rate_class, shipment_rate_description) VALUES ('FULL', 'Full Price')
INSERT INTO dbo.SHIPMENT_RATE (shipment_rate_class, shipment_rate_description) VALUES ('50OFF', '50% Discount')
INSERT INTO dbo.SHIPMENT_RATE (shipment_rate_class, shipment_rate_description) VALUES ('10OFF', '10% Discount')

-- Insert data into dbo.SHIPMENT
INSERT INTO dbo.SHIPMENT ( shipper_id, shipment_description, shipment_weight, shipment_rate_id, carrier_id)
	VALUES ( 1, 'Machine Parts', 130.54, 1, 1)
INSERT INTO dbo.SHIPMENT ( shipper_id, shipment_description, shipment_weight, shipment_rate_id, carrier_id)
	VALUES ( 3, 'Office Supplies', 10.05, 2, 3)
INSERT INTO dbo.SHIPMENT (shipper_id, shipment_description, shipment_weight, shipment_rate_id, carrier_id)
	VALUES ( 2, 'Basketball Hoops', 13.4, 2, 4)
INSERT INTO dbo.SHIPMENT ( shipper_id, shipment_description, shipment_weight, shipment_rate_id, carrier_id)
	VALUES ( 2, 'Football Helmets', 25.98, 2, 2)
INSERT INTO dbo.SHIPMENT ( shipper_id, shipment_description, shipment_weight, shipment_rate_id, carrier_id)
	VALUES ( 1, 'Conveyor System', 250.10, 1, 5)
INSERT INTO dbo.SHIPMENT ( shipper_id, shipment_description, shipment_weight, shipment_rate_id, carrier_id)
