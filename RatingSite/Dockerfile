# Use an official SQL Server 2022 image as your base image
FROM mcr.microsoft.com/mssql/server:2022-latest

# Install necessary tools and add the Microsoft repository
USER root
RUN apt-get update && apt-get install -y gnupg curl && \
    curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add - && \
    curl https://packages.microsoft.com/config/ubuntu/18.04/prod.list | tee /etc/apt/sources.list.d/msprod.list && \
    apt-get update && apt-get install -y mssql-tools unixodbc-dev

# Switch back to a non-root user
USER mssql
