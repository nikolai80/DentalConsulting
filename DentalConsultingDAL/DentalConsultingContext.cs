using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class DentalConsultingContext : DbContext
		{
		public DentalConsultingContext() : base(ConfigurationManager.ConnectionStrings["DentalConsulting"].ToString()) { }

		public DbSet<Article> Articles
			{
			get;
			set;
			}

		public DbSet<ArticleContent> ArticleContents
			{
			get;
			set;
			}

		public DbSet<User> Users
			{
			get;
			set;
			}

		public DbSet<TestResult> TestResults
		{
			get; set; }

		public DbSet<Role> Roles
		{
			get; set; }

		public DbSet<Reminder> Reminders
		{
			get; set; }

		public DbSet<Advice> Advices
		{
			get; set; }

		public DbSet<HospitalChart> HospitalCharts
		{
			get; set; }

		public DbSet<DentalCard> DentalCards
		{
			get; set; }

		public DbSet<Chat> Chats
		{
			get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
			{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			}
		}
	}
