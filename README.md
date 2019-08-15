# OdaLibrary
Final Countdown Project

#Entity Index

##Customer  
  
Definition of the customers:

	[id] [int] IDENTITY(1,1) NOT NULL,  
	[name] [varchar](100) NULL,  
	[mobilephone] [varchar](13) NULL,  
	[email] [varchar](100) NULL,  
    [status] [bit] NOT NULL  

    Status:  
    0 - Inactive  
    1 - Active

##Score

Definition of the customer's reputation among the community.  
Each positive or negative review are incremental to his history:

	[id] [int] IDENTITY(1,1) NOT NULL,
	[custid] [int] NULL,
	[ownerpositive] [int] NULL,
	[ownernegative] [int] NULL,
	[borrowerpositive] [int] NULL,
	[borrowernegative] [int] NULL

##Spot
  
Definition of the available trading spots:  

	[id] [int] IDENTITY(1,1) NOT NULL,  
	[name] [varchar](100) NULL,  
	[document] [varchar](14) NULL,  
	[address] [varchar](255) NULL,  
	[telephone] [varchar](13) NULL,  
	[workinghours] [varchar](100) NULL,  
    [status] [bit] NOT NULL  

    Status:  
    0 - Inactive  
    1 - Active

##MTGCard

Set existing cards already included in the application:

	[id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[set] [varchar](100) NOT NULL,
	[setcode] [varchar](5) NULL
	[mtgid] [int] NOT NULL

##Shelf

A shelf is the inventory each user has for loan:

	[id] [int] NOT NULL,  
	[custid] [int] NULL,  
	[itemid] [int] NULL,  
	[conservation] [varchar](100) NULL,  
	[quantity] [int] NULL,  
	[marketprice] [numeric](10, 2) NULL  

##Wish

A wish contains the item that a borrower wishes for.

	[id] [int] IDENTITY(1,1) NOT NULL,  
	[custid] [int] NULL,  
	[ownerid] [int] NULL,  
	[itemid] [int] NULL,  
	[quantity] [int] NULL,  
	[returndate] [date] NOT NULL,  
	[expiringdate] [date] NOT NULL,  
	[status] [int] NOT NULL  
    Status:  
    0 - Cancelled  
    1 - Open  
    2 - Attended  
    3 - Granted  
    4 - Expired

##Exchange

Sets the exchange confirmation of a wish that has been attended to.

	[id] [int] IDENTITY(1,1) NOT NULL,  
	[wishid] [int] NULL,  
	[bagid] [int] NULL,  
	[status] [int] NOT NULL  
    Status:  
    0 - Cancelled  
    1 - Attended  
    2 - Granted  
    3 - Accomplished

##Bag

A bag holds items the user borrowed.

	[id] [int] NOT NULL,  
	[custid] [int] NULL,  
	[ownerid] [int] NULL,  
	[itemid] [int] NULL,  
	[quantity] [int] NULL,  
	[wishid] [int] NULL  
    [Status] [int] NOT NULL  
    Status:  
    0 - NotReturned  
    1 - ReturnedOK  
    2 - ReturnedNOK

##Box

Definitions of the boxes in each spot:

	[id] [int] NOT NULL,  
	[boxnumber] [int] NOT NULL,  
	[spotid] [int] NULL,  
	[custid] [int] NULL,  
	[ownerid] [int] NULL,
	[status] [bit] NOT NULL  
    Status:  
    0 - Empty  
    1 - Occupied  

##BoxContent

Definitions of the items in each box:

	[boxid] [int] NOT NULL,  
	[itemid] [int] NULL,  
	[quantity] [int] NULL