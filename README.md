# Facturosaurus - application for managing tasks and creating invoices

## Table of contents

* [General info](#general-info)
* [Technologies](#technologies)
* [Features](#features)
* [Status](#status)
* [Sources](#sources)
* [Setup](#setup)

  

## General info

The application was created to consolidate knowledge after completing the courses. At the same time, I wanted the project to be useful. Currently, it is used by a one-man company to manage projects and customers and also allows for issuing invoices.

## Technologies

The project is created with:

* .NET version: 5.0

* AutoMapper version: 8.1.0

* ASP .NET

* FluentValidation AspNetCore version: 9.4.0

* Authentication JwtBearer version: 5.0.17

* Microsoft Entity Framework Core version: 5.0.17

* Microsoft SQL Server Database

* HTML, CSS - for simple reports

* Windows Forms

  

## Features

###  REST API (Facturosaurus.Api):
-   User account management
	(Creating new, deleting, modifying, assigning user roles, authorization and authentication using the jwt token)

-   Company's data
	(Updating company data. Downloading current data and data for a specific date)

-   Customers
	(Create, modify, delete, view clients)

-   Invoices
	(Issuing invoices based on the company and selected contractor's data. Viewing, modifying and printing issued invoices)

-   Reports
	(Creating simple reports: unpaid invoices, customer lists with details, list of customer invoices)

###  WinForms (Facturosaurus.Forms):
The project is a user interface that uses all the functionalities of RestAPI.

  
  

## Status

The project is still being developed. In the future, new functionalities will be added to make everyday work on tasks for clients in a small company easier.

  

## Sources

ASP .NET tutorial by Jakub Kozera [@https://github.com/jakubkozera](https://github.com/jakubkozera)

  

## Setup

To run this project, download the solution and run the project.
