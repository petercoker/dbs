USE [1725266]
GO
/****** Object:  Table [dbo].[tblAccounts]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccounts](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ReferenceId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblAssociation]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAssociation](
	[AssociationId] [int] IDENTITY(1,1) NOT NULL,
	[Customer1] [int] NOT NULL,
	[ReferenceId] [int] NOT NULL,
	[Customer2] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AssociationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCustomers]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[AccountId] [int] NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[EmailAddress] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblReference]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblReference](
	[ReferenceId] [int] IDENTITY(1,1) NOT NULL,
	[ReferenceDescription] [varchar](50) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSecurities]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSecurities](
	[SecurityId] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[ReferenceId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SecurityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vwAssociationDetails]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwAssociationDetails]
AS
SELECT tblCustomers.FullName,
              tblReference.ReferenceDescription,
              tblCustomers2.FullName AS tblCustomers2FullName

FROM tblAssociation

INNER JOIN 
	tblCustomers
ON
	tblAssociation.Customer1 = tblCustomers.CustomerId

INNER JOIN 
	tblReference
ON 	
tblAssociation.ReferenceId = tblReference.ReferenceId

INNER JOIN 
	tblCustomers tblCustomers2
ON
	tblAssociation.Customer2 =  tblCustomers2.CustomerId






GO
/****** Object:  View [dbo].[vwDeletedReferenceData]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwDeletedReferenceData]
AS
SELECT ReferenceId, 
	   ReferenceDescription,
	   IsDeleted

FROM dbo.tblReference
WHERE IsDeleted = 1


GO
/****** Object:  View [dbo].[vwReferenceDataNonDelete]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwReferenceDataNonDelete]
AS
SELECT ReferenceId, 
	   ReferenceDescription
FROM tblReference



GO
SET IDENTITY_INSERT [dbo].[tblAccounts] ON 

INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (1, 1001, 1, 1)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (2, 1002, 2, 2)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (3, 1003, 3, 3)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (4, 1004, 4, 4)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (5, 1005, 5, 5)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (6, 1006, 6, 6)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (7, 1007, 7, 7)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (8, 1008, 8, 3)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (9, 1009, 9, 2)
INSERT [dbo].[tblAccounts] ([AccountId], [AccountNumber], [CustomerId], [ReferenceId]) VALUES (10, 1010, 10, 4)
SET IDENTITY_INSERT [dbo].[tblAccounts] OFF
SET IDENTITY_INSERT [dbo].[tblAssociation] ON 

INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (1, 1, 13, 6)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (2, 2, 14, 7)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (3, 3, 15, 8)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (4, 4, 16, 9)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (5, 5, 17, 10)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (6, 6, 18, 1)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (7, 7, 19, 2)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (8, 8, 20, 3)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (9, 9, 21, 4)
INSERT [dbo].[tblAssociation] ([AssociationId], [Customer1], [ReferenceId], [Customer2]) VALUES (10, 10, 22, 5)
SET IDENTITY_INSERT [dbo].[tblAssociation] OFF
SET IDENTITY_INSERT [dbo].[tblCustomers] ON 

INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (1, N'Maurice Barrus', 1, N'Nigeria', 775550195, N'MauriceBarrus@gmail.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (2, N'Shandra Carrasco', 2, N'France', 775550188, N'ShandraCarrasco@hotmail.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (3, N'Valerie Kalis', 3, N'Sweden', 775550194, N'ValerieKalis@hotmail.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (4, N'Jong Gundersen', 4, N'USA', 775550117, N'JongGundersen@gmail.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (5, N'Hope Griffieth', 5, N'Ireland', 775550126, N'HopeGriffieth@yahoo.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (6, N'Joseph Hines', 6, N'China', 2025550134, N'JosephHines@teleworm.us')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (7, N'Aileen Corchado', 7, N'Japan', 2025550156, N'AileenCorchado@armyspy.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (8, N'Brandi Purkey', 8, N'Spain', 2025550179, N'BrandiPurkey@teleworm.us')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (9, N'Shirley Watkins', 9, N'Italy', 2025550189, N'ShirleyWatkins@rhyta.com')
INSERT [dbo].[tblCustomers] ([CustomerId], [FullName], [AccountId], [Country], [Phone], [EmailAddress]) VALUES (10, N'Jack Nelson', 10, N'Russia', 2025550171, N'JackNelson@dayrep.com')
SET IDENTITY_INSERT [dbo].[tblCustomers] OFF
SET IDENTITY_INSERT [dbo].[tblReference] ON 

INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (1, N'Savings Account', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (2, N'Current Account', 1)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (3, N'Checking Account', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (4, N'Basic Checking Account', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (5, N'Interest-Bearing Checking Account', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (6, N'Money Market Deposit Account', 1)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (7, N'Certificates of Deposit', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (8, N'Gold', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (9, N'Cash', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (10, N'Shares', 1)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (11, N'Bonds', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (12, N'Property', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (13, N'CEO', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (14, N'Consultant', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (15, N'Office Manager', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (16, N'HR Manager', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (17, N'Lawyer', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (18, N'CFO', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (19, N'Lawyer', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (20, N'Chairman', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (21, N'Intern', 0)
INSERT [dbo].[tblReference] ([ReferenceId], [ReferenceDescription], [IsDeleted]) VALUES (22, N'Head Of Market', 0)
SET IDENTITY_INSERT [dbo].[tblReference] OFF
SET IDENTITY_INSERT [dbo].[tblSecurities] ON 

INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (1, 1, 8)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (2, 2, 9)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (3, 3, 10)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (4, 4, 11)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (5, 5, 12)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (6, 6, 8)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (7, 7, 10)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (8, 8, 12)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (9, 9, 9)
INSERT [dbo].[tblSecurities] ([SecurityId], [AccountId], [ReferenceId]) VALUES (10, 10, 11)
SET IDENTITY_INSERT [dbo].[tblSecurities] OFF
/****** Object:  Index [UQ_Customer1AndReferenceId]    Script Date: 15/12/2017 21:14:07 ******/
ALTER TABLE [dbo].[tblAssociation] ADD  CONSTRAINT [UQ_Customer1AndReferenceId] UNIQUE NONCLUSTERED 
(
	[Customer1] ASC,
	[ReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAccounts]  WITH CHECK ADD  CONSTRAINT [fkAccountType_tblReference] FOREIGN KEY([ReferenceId])
REFERENCES [dbo].[tblReference] ([ReferenceId])
GO
ALTER TABLE [dbo].[tblAccounts] CHECK CONSTRAINT [fkAccountType_tblReference]
GO
ALTER TABLE [dbo].[tblAccounts]  WITH CHECK ADD  CONSTRAINT [fktblAccounts_tblCustomers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[tblCustomers] ([CustomerId])
GO
ALTER TABLE [dbo].[tblAccounts] CHECK CONSTRAINT [fktblAccounts_tblCustomers]
GO
ALTER TABLE [dbo].[tblAssociation]  WITH CHECK ADD  CONSTRAINT [fkAssociationType_tblReference] FOREIGN KEY([ReferenceId])
REFERENCES [dbo].[tblReference] ([ReferenceId])
GO
ALTER TABLE [dbo].[tblAssociation] CHECK CONSTRAINT [fkAssociationType_tblReference]
GO
ALTER TABLE [dbo].[tblAssociation]  WITH CHECK ADD  CONSTRAINT [fktblAssociation_tblCustomers] FOREIGN KEY([Customer1])
REFERENCES [dbo].[tblCustomers] ([CustomerId])
GO
ALTER TABLE [dbo].[tblAssociation] CHECK CONSTRAINT [fktblAssociation_tblCustomers]
GO
ALTER TABLE [dbo].[tblAssociation]  WITH CHECK ADD  CONSTRAINT [fktblAssociationType_tblCustomers] FOREIGN KEY([Customer2])
REFERENCES [dbo].[tblCustomers] ([CustomerId])
GO
ALTER TABLE [dbo].[tblAssociation] CHECK CONSTRAINT [fktblAssociationType_tblCustomers]
GO
ALTER TABLE [dbo].[tblSecurities]  WITH CHECK ADD  CONSTRAINT [fkSecuritiesType_tblReference] FOREIGN KEY([ReferenceId])
REFERENCES [dbo].[tblReference] ([ReferenceId])
GO
ALTER TABLE [dbo].[tblSecurities] CHECK CONSTRAINT [fkSecuritiesType_tblReference]
GO
ALTER TABLE [dbo].[tblSecurities]  WITH CHECK ADD  CONSTRAINT [fktblSecurities_tblAccounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[tblAccounts] ([AccountId])
GO
ALTER TABLE [dbo].[tblSecurities] CHECK CONSTRAINT [fktblSecurities_tblAccounts]
GO
/****** Object:  StoredProcedure [dbo].[uspAddNewAssociation]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	<1725266, Peter Coker>
-- Create date: <10/12/2017,>
-- Description:  <Ability to add a new Association parameterised stored>
-- ============================================
Create Procedure [dbo].[uspAddNewAssociation]
@Customer1 int,
@ReferenceId2 int,
@Customer2 int
AS
BEGIN  
INSERT INTO tblAssociation (Customer1, ReferenceId, Customer2)
VALUES (@Customer1, @ReferenceId2, @Customer2)   
END 

GO
/****** Object:  StoredProcedure [dbo].[uspAddNewCustomer]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	<1725266, Peter Coker>
-- Create date: <10/12/2017,>
-- Description:  <Ability to add a new Customer  via parameterised Stored Procedure>
-- ============================================
Create Procedure [dbo].[uspAddNewCustomer]
@FullName varchar (50),
@AccountId int,
@Country varchar (50),
@Phone int,
@EmailAddress varchar (50)

AS
BEGIN  
INSERT INTO tblCustomers (FullName, AccountId, Country, Phone, EmailAddress)
VALUES (@FullName, @AccountId, @Country, @Phone, @EmailAddress)   
END 


GO
/****** Object:  StoredProcedure [dbo].[uspDeleteCustomerAndForeginKey]    Script Date: 15/12/2017 21:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	<1725266, Peter Coker>
-- Create date: <10/12/2017,>
-- Description:	<Ability to delete a Customer and foreign key records associated with this Customer via parameterised stored>
-- ============================================
CREATE PROCEDURE [dbo].[uspDeleteCustomerAndForeginKey] 
@AssociationId int,
@ReferenceId int,
@SecurityId int,
@AccountId int,
@Customer2 int,
@CustomerId int
AS 
BEGIN  
DELETE FROM tblAssociation WHERE AssociationId = @AssociationId
DELETE FROM tblReference WHERE ReferenceId = @ReferenceId
DELETE FROM tblSecurities WHERE SecurityId = @SecurityId 
DELETE FROM tblAccounts WHERE AccountId = @AccountId
DELETE FROM tblAssociation WHERE Customer2 = @Customer2
DELETE FROM tblCustomers WHERE CustomerId = @CustomerId
END

GO
