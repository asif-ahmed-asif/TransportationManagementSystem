# Transportatin Management System
Our software project 1 for AIUB under the supervision of faculty Hasibul Hasan Siam


## Description
Transportation Management System is a multi-faceted, user centered desktop software system which focuses on eliminating the inefficiencies and difficulties of the bookings and ticketing of transportation in Bangladesh.

There are three user classes in this project:
1.	Admin (Maintainer and administer of the system)
2.	Cashier (Responsible for selling tickets)
3.	Accountant (Responsible for everything related to finance)

These three user classes will work in a simultaneous to manner to ensure a seamless experience for customers by automating routing, generating secure digital tickets etc.


## Features

**1. Online Database**

The database of the entire systemn has been taken online by using Microsoft Azure. All registered users of the system can login from anywhere in the world 
![Azure Online Database Screenshot](Readme%20attachments/Online%20db.png)


**2. Ticket Booking and Printing**

Cashier can fill out the "from" and "to" textboxes in the page and choose the date of departure as well as choosing the bus type for the customer (AC/Non AC)

![](Readme%20attachments/CashierDashboard.png)

Cashier can then select from a bus from a given  given list based on the number of seats a customer wants to avail

![](Readme%20attachments/CashierDashboard2.png)

Cashier will then select the seats from the popup

- Already booked seats will be unavailabe for selection and are shown to user as orange coloured

![](Readme%20attachments/CashierDashboard3.png)

After submitting customer's phone number and name the ticket can be printed by the cashier

![](Readme%20attachments/CashierDashboard4.png)


**3. Route Insertion and Deletion**

Routes for buses can be inserted or deleted by the admins. Each route must be assigned all the values that are present in this form to be inserted into the system

![](Readme%20attachments/RouteForm1.png)

**4. Route Searching**

Routes can be searched by name in this form from the list on the right hand side

![](Readme%20attachments/RouteForm3.png)

**5. Return Routes Inertion**

When a bus goes to a destination it also needs a return path to return from that destination, return routes page are designed for that purpose

![](Readme%20attachments/RouteForm2.png)

- Departure, destination and bus number cannot be changed as this is designed for the buses to return. Only the departure and arrival time can be set

- The original route will be shown before the return route on this page

**5. User Creation and Update**

Admin can create new users and update the information of existing ones

![](Readme%20attachments/UserForm1.png)

Admin can also search for the users from the users list

![](Readme%20attachments/UserForm2.png)

**6. Bus Operations**

Buses can be created, updated and searched by the admin

![](Readme%20attachments/BusForm1.png)