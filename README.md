WebApiUserModule
================
To build Create a hibernate.cfg.xml file under Web.Api.UserModule and include the following text as content, 
please change the database connection string according.

<?xml version="1.0" encoding="utf-8" ?>
<hibernate-configuration xmlns="urn:nhibernate-configuration-2.2">
  <session-factory>
    <property name="dialect">NHibernate.Dialect.MySQLDialect</property>
    <property name="connection.provider">NHibernate.Connection.DriverConnectionProvider</property>
    <property name="connection.connection_string">Server=localhost;Database=testwebapi;User ID=userid;Password=password;</property>
    <property name="connection.driver_class">NHibernate.Driver.MySqlDataDriver</property>       
    <mapping resource="WebApi.UserModule.Mappings.IdentityRole.hbm.xml" assembly="WebApi.UserModule" />
    <mapping resource="WebApi.UserModule.Mappings.IdentityUser.hbm.xml" assembly="WebApi.UserModule" />
    <mapping resource="WebApi.UserModule.Mappings.IdentityUserClaim.hbm.xml" assembly="WebApi.UserModule" />
  </session-factory>
</hibernate-configuration>