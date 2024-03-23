# PayWave

**PayWave** is a Cartesi template for virtual wallets, using Circle APIs.

## Creator
----

- [Néstor Nicolás Campos Rojas](https://www.linkedin.com/in/nescampos/)

## Functions

With PayWave, you can:
- Create one or more wallets for user.
- Manage balance and blockchain address per wallet to receive money.
- Manage an address book to create recipients for transactions.
- Move money between accounts.
- Send money to third parties.
- Create payments links to share with friends.
- Integrate with apps and webs thanks to POST requests.

## Technologies

PayWave is built with:
- .NET Core 6 (it is a MVC web app).
- [Circle API](https://developers.circle.com/)
- Javascript
- Cartesi

## Configuration

You need to configure some keys to run this web app.

1. First, get a Circle API key and update in the appsettings.json (_CircleAPIKey_ variable).
2. Create a SQL Server database in some server, get the string connection.
3. Set the docker environment variables _CircleAPIKey_ and _SQLServerDatabaseConnection_ with the keys and connections created.
4. Run the Entity Framework command to create tables, inside the container.

```sh
    update-database
```
5.Deploy in Cartesi [following the instructions](https://github.com/cartesi/DevGuide/tree/main).
6. Run the web app and start to use it.
