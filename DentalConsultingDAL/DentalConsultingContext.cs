using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using DentalConsultingData;

namespace DentalConsultingDAL
	{

	public class DentalConsultingContext : DbContext
		{
		public DentalConsultingContext() : base("DentalConsultingContext") { }

		public DbSet<Article> Articles
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<ArticleContent> ArticleContents
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<User> Users
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<TestResult> TestResults
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<Role> Roles
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<Reminder> Reminders
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<Advice> Advices
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<HospitalChart> HospitalCharts
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<DentalCard> DentalCards
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		public DbSet<Chat> Chats
			{
			get
				{
				throw new System.NotImplementedException();
				}
			set
				{
				}
			}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
			{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			}
		}
	}
