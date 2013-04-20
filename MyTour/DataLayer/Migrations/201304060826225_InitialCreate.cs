namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        DateOfBirth = c.DateTime(),
                        CustomerSince = c.DateTime(),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Booking",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ContinueAsGuest = c.Boolean(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Trip",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingId = c.Int(nullable: false),
                        ChaffeurId = c.Int(),
                        VehicleId = c.Int(),
                        TripDate = c.DateTime(nullable: false),
                        PlaceId = c.Int(nullable: false),
                        DistanceCovered = c.Double(nullable: false),
                        SpecialInstructions = c.String(maxLength: 100),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Booking", t => t.BookingId, cascadeDelete: true)
                .ForeignKey("dbo.Chaffeurs", t => t.ChaffeurId)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId)
                .ForeignKey("dbo.Place", t => t.PlaceId, cascadeDelete: true)
                .ForeignKey("dbo.Booking", t => t.Booking_Id)
                .Index(t => t.BookingId)
                .Index(t => t.ChaffeurId)
                .Index(t => t.VehicleId)
                .Index(t => t.PlaceId)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.Chaffeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisrtName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Seats = c.Int(nullable: false),
                        ChildRestraint = c.Boolean(nullable: false),
                        FourWheelDrive = c.Boolean(nullable: false),
                        Pictures = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Place",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuburbId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Pictures = c.Binary(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suburbs", t => t.SuburbId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.SuburbId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PostCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Number = c.String(nullable: false, maxLength: 12),
                        PhoneType = c.Int(nullable: false),
                        IsPreferred = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Royalties",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        status = c.String(),
                        DistanceTravelled = c.Single(nullable: false),
                        MemberSince = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        SuburbId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        StreetAddress1 = c.String(nullable: false, maxLength: 50),
                        StreetAddress2 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suburbs", t => t.SuburbId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.SuburbId)
                .Index(t => t.StateId)
                .Index(t => t.CountryId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(nullable: false),
                        Message = c.String(nullable: false, maxLength: 1500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Addresses", new[] { "CustomerId" });
            DropIndex("dbo.Addresses", new[] { "CountryId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "SuburbId" });
            DropIndex("dbo.Royalties", new[] { "Id" });
            DropIndex("dbo.Phones", new[] { "CustomerId" });
            DropIndex("dbo.Place", new[] { "StateId" });
            DropIndex("dbo.Place", new[] { "SuburbId" });
            DropIndex("dbo.Trip", new[] { "Booking_Id" });
            DropIndex("dbo.Trip", new[] { "PlaceId" });
            DropIndex("dbo.Trip", new[] { "VehicleId" });
            DropIndex("dbo.Trip", new[] { "ChaffeurId" });
            DropIndex("dbo.Trip", new[] { "BookingId" });
            DropIndex("dbo.Booking", new[] { "CustomerId" });
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Addresses", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "SuburbId", "dbo.Suburbs");
            DropForeignKey("dbo.Royalties", "Id", "dbo.Customer");
            DropForeignKey("dbo.Phones", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Place", "StateId", "dbo.States");
            DropForeignKey("dbo.Place", "SuburbId", "dbo.Suburbs");
            DropForeignKey("dbo.Trip", "Booking_Id", "dbo.Booking");
            DropForeignKey("dbo.Trip", "PlaceId", "dbo.Place");
            DropForeignKey("dbo.Trip", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Trip", "ChaffeurId", "dbo.Chaffeurs");
            DropForeignKey("dbo.Trip", "BookingId", "dbo.Booking");
            DropForeignKey("dbo.Booking", "CustomerId", "dbo.Customer");
            DropTable("dbo.Contact");
            DropTable("dbo.Countries");
            DropTable("dbo.Addresses");
            DropTable("dbo.Royalties");
            DropTable("dbo.Phones");
            DropTable("dbo.States");
            DropTable("dbo.Suburbs");
            DropTable("dbo.Place");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Chaffeurs");
            DropTable("dbo.Trip");
            DropTable("dbo.Booking");
            DropTable("dbo.Customer");
        }
    }
}
