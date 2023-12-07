using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALSN_Db.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "HeadOfAccounts",
                columns: table => new
                {
                    HeadOfAccountID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidityFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidityTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadOfAccounts", x => x.HeadOfAccountID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "OrderRepitions",
                columns: table => new
                {
                    OrderRepitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRepitionNo = table.Column<int>(type: "int", nullable: false),
                    OrderRepitionTimeLimitHrs = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRepitions", x => x.OrderRepitionID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modules = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageExpertise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    ClaimsID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.ClaimsID);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberConfirmed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockOutEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccessedFailedCount = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID1 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Countries_CountryID1",
                        column: x => x.CountryID1,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedBackID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<long>(type: "bigint", nullable: false),
                    FeedBackDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedBackID);
                    table.ForeignKey(
                        name: "FK_Feedback_Users_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuestID = table.Column<long>(type: "bigint", nullable: false),
                    TranslationOfficeID = table.Column<long>(type: "bigint", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentDocument = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommissionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_TranslationOfficeID",
                        column: x => x.TranslationOfficeID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslationOfficeTranslators",
                columns: table => new
                {
                    TranslationOfficeTranslatorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslatorID = table.Column<long>(type: "bigint", nullable: false),
                    TranslationOfficeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationOfficeTranslators", x => x.TranslationOfficeTranslatorID);
                    table.ForeignKey(
                        name: "FK_TranslationOfficeTranslators_Users_TranslationOfficeID",
                        column: x => x.TranslationOfficeID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranslationOfficeTranslators_Users_TranslatorID",
                        column: x => x.TranslatorID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translators",
                columns: table => new
                {
                    TranslatorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    SourceLanguageID = table.Column<int>(type: "int", nullable: false),
                    TargetLanguageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translators", x => x.TranslatorID);
                    table.ForeignKey(
                        name: "FK_Translators_Languages_SourceLanguageID",
                        column: x => x.SourceLanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translators_Languages_TargetLanguageID",
                        column: x => x.TargetLanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translators_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBanks",
                columns: table => new
                {
                    BankID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    TranslationOfficeID = table.Column<long>(type: "bigint", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBanks", x => x.BankID);
                    table.ForeignKey(
                        name: "FK_UserBanks_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    UserID1 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID1",
                        column: x => x.UserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ChatID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    SenderID = table.Column<long>(type: "bigint", nullable: false),
                    ReceiverID = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatID);
                    table.ForeignKey(
                        name: "FK_Chats_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_Users_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_Users_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderAssignments",
                columns: table => new
                {
                    OrderAssignementID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    TranslatorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAssignments", x => x.OrderAssignementID);
                    table.ForeignKey(
                        name: "FK_OrderAssignments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderAssignments_Users_TranslatorID",
                        column: x => x.TranslatorID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfWords = table.Column<long>(type: "bigint", nullable: false),
                    IsFreeAmendments = table.Column<bool>(type: "bit", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentAmount = table.Column<long>(type: "bigint", nullable: false),
                    SourceLanguageID = table.Column<int>(type: "int", nullable: false),
                    TargetLanguageID = table.Column<int>(type: "int", nullable: false),
                    OrderRepitionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Languages_SourceLanguageID",
                        column: x => x.SourceLanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Languages_TargetLanguageID",
                        column: x => x.TargetLanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderRepitions_OrderRepitionID",
                        column: x => x.OrderRepitionID,
                        principalTable: "OrderRepitions",
                        principalColumn: "OrderRepitionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPayments",
                columns: table => new
                {
                    PaymentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    GuestID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_OrderPayments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPayments_Users_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<long>(type: "bigint", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartyID = table.Column<long>(type: "bigint", nullable: false),
                    PaymentTypeID = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Users_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Users_PartyID",
                        column: x => x.PartyID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<long>(type: "bigint", nullable: false),
                    AdminID = table.Column<long>(type: "bigint", nullable: false),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentID = table.Column<long>(type: "bigint", nullable: false),
                    HeadOfAccountID = table.Column<long>(type: "bigint", nullable: false),
                    Debit = table.Column<long>(type: "bigint", nullable: false),
                    Credit = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailID);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_HeadOfAccounts_HeadOfAccountID",
                        column: x => x.HeadOfAccountID,
                        principalTable: "HeadOfAccounts",
                        principalColumn: "HeadOfAccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_OrderID",
                table: "Chats",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ReceiverID",
                table: "Chats",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_SenderID",
                table: "Chats",
                column: "SenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_GuestID",
                table: "Feedback",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAssignments_OrderID",
                table: "OrderAssignments",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAssignments_TranslatorID",
                table: "OrderAssignments",
                column: "TranslatorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderRepitionID",
                table: "OrderDetails",
                column: "OrderRepitionID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SourceLanguageID",
                table: "OrderDetails",
                column: "SourceLanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TargetLanguageID",
                table: "OrderDetails",
                column: "TargetLanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_GuestID",
                table: "OrderPayments",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_OrderID",
                table: "OrderPayments",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GuestID",
                table: "Orders",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TranslationOfficeID",
                table: "Orders",
                column: "TranslationOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_HeadOfAccountID",
                table: "PaymentDetails",
                column: "HeadOfAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_PaymentID",
                table: "PaymentDetails",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AdminID",
                table: "Payments",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderID",
                table: "Payments",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PartyID",
                table: "Payments",
                column: "PartyID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypeID",
                table: "Payments",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleID",
                table: "RoleClaims",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AdminID",
                table: "Tickets",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_GuestID",
                table: "Tickets",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OrderID",
                table: "Tickets",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationOfficeTranslators_TranslationOfficeID",
                table: "TranslationOfficeTranslators",
                column: "TranslationOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_TranslationOfficeTranslators_TranslatorID",
                table: "TranslationOfficeTranslators",
                column: "TranslatorID");

            migrationBuilder.CreateIndex(
                name: "IX_Translators_SourceLanguageID",
                table: "Translators",
                column: "SourceLanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Translators_TargetLanguageID",
                table: "Translators",
                column: "TargetLanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Translators_UserID",
                table: "Translators",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserBanks_UserID",
                table: "UserBanks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID1",
                table: "UserRoles",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryID1",
                table: "Users",
                column: "CountryID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "OrderAssignments");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderPayments");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "TranslationOfficeTranslators");

            migrationBuilder.DropTable(
                name: "Translators");

            migrationBuilder.DropTable(
                name: "UserBanks");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "OrderRepitions");

            migrationBuilder.DropTable(
                name: "HeadOfAccounts");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
