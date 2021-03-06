# DockerCon 2020
Demo code from "Dev and Test Agility for your Database with Docker"

Watch the 30 minute session on demand at: 
https://docker.events.cube365.net/docker/dockercon/content/Videos/gXQAMy3hS8yHMbSKL

Session Abstract:
Agile practices teach us how to deal with evolving applications but so often the data store is overlooked as a component of your application lifecycle. Database servers are monolothic, resource intensive and mostly viewed as set in stone. Encapsulating your database server in a container and your database in a storage container can dramatically lighten the load and make your database as agile as your model and other processes. And you can even use a serious enterprise class database like SQL Server this way. This session will show how to benefit from using a containerized version of SQL Server for Linux during development and testing. We'll also address concerns about data that needs to be persisted. You'll also get a peek at the DevOps side of this, including using images in your CI/CD process.

This will pull Microsoft's SQL Server image and Microsoft's dotnet core & sdk images

Be sure to cd to the Agilistas folder before running either of the docker-compose files.

Stage-One Branch
This is the "before", where we have a running app

Stage-Two Branch
This is after there's been a small model change which also demands a change to the database schema and seed data. 

See theurlist.com/lermandockercon2020  for links to references.
