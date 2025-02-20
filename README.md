# Project Description
Marketing System is a Windows-based application connected to a MySQL database, designed to streamline operations for employees working in a market's Marketing, Purchasing Unit, and Store Attendant departments. The system provides an intuitive user interface, enabling staff to efficiently manage their tasks, including product marketing, inventory procurement, and store management.

This application enhances workflow automation, reduces manual workload, and ensures seamless communication between different departments, ultimately improving overall efficiency in the market's operations.

Developed with: C# and MySQL
Features: Inventory management, purchase tracking, marketing tools, and department-specific functionalities.

# Login Page
In the Login Page, users can enter the system using their username and department information.

![WhatsApp Image 2025-02-19 at 22 11 46 (3)](https://github.com/user-attachments/assets/b8f8a48f-e18a-4717-858f-38c36f51b95d)

![WhatsApp Image 2025-02-19 at 22 11 46 (4)](https://github.com/user-attachments/assets/9c382fbd-f9a5-4e42-878a-b05bf95cbdfb)

# Marketing
In the Marketing Department window, user can view customer information (Customer ID, Customer Name) and the number of products they have purchased. Whenever user clicks on a row in the table, the selected customer's data will appear at the top of the window. Additionally, user can update the quantity of a product purchased by selecting the product name or delete the purchase. The system will retrieve the unit price from the SQL database when a product ID is selected, and once the quantity is entered, it will automatically calculate the total price.

![WhatsApp Image 2025-02-19 at 22 11 46 (6)](https://github.com/user-attachments/assets/4eb9b6ee-402e-4832-a7ab-4625e6db7067)

![WhatsApp Image 2025-02-19 at 22 11 46 (5)](https://github.com/user-attachments/assets/c90c7365-4404-4042-be65-cc485a049fbd)


In the Add Customer window, user can create a new customer in the database.

![WhatsApp Image 2025-02-19 at 22 11 46 (3) copy](https://github.com/user-attachments/assets/f33d892a-3f49-4441-bafb-96d6abea994a)

![WhatsApp Image 2025-02-19 at 22 11 46 (7)](https://github.com/user-attachments/assets/d3d83dc7-8b3d-43d1-bb3e-0924cbe8e8cd)

To view purchase statistics, user can click the button at the bottom of marketing department windows. In the purchase statistics window, user can retrieve data from the database by selecting a product ID to list who bought the item or selecting a customer ID to see which products that customer purchased. Additionally, user can see the total number of customers, the total purchased amount, the ID of the best-selling product, and the customer ID of the highest-spending customer by clicking the respective buttons.

![WhatsApp Image 2025-02-19 at 22 11 46 (3) copy 2](https://github.com/user-attachments/assets/802c36b4-f0bf-4241-97e2-0408032d00dc)

![WhatsApp Image 2025-02-19 at 22 11 47](https://github.com/user-attachments/assets/aaa82ea9-fc54-4874-beed-2fef846c2728)

# Purchasing Unit
For purchasing department, user should select Purchasing Unit in the Login Page.

![WhatsApp Image 2025-02-19 at 22 11 47 (1)](https://github.com/user-attachments/assets/6402a04a-51ff-4daa-b190-ac9dfe2a612b)

The list of order data will appear at the bottom of the window. User can fill in the order details in the upper fields when user clicks on a list item. Additionally, user can update the order date by selecting an order, changing the date, and clicking the Update Order Date button.

![WhatsApp Image 2025-02-19 at 22 11 47 (2)](https://github.com/user-attachments/assets/af924b17-7d11-4c14-a474-6ab039c807cd)

![WhatsApp Image 2025-02-19 at 22 11 47 (5)](https://github.com/user-attachments/assets/b7895b94-a13a-4343-ae91-d561554ce43f)

![WhatsApp Image 2025-02-19 at 22 11 47 (4)](https://github.com/user-attachments/assets/c74a4a82-17c2-47ba-90d2-f7e95636c3df)

User can also modify the order quantity by entering a new amount and clicking the Update Order Amount button or delete an order by clicking the Delete button.

![WhatsApp Image 2025-02-19 at 22 11 48](https://github.com/user-attachments/assets/95736e5b-3c2a-412e-b4db-ecd89c8939f1)

![WhatsApp Image 2025-02-19 at 22 11 47 (3)](https://github.com/user-attachments/assets/7e0578a4-561b-4966-8b42-aea47e1e6d4e)

![WhatsApp Image 2025-02-19 at 22 11 49](https://github.com/user-attachments/assets/86c277af-bb4e-4e4f-b620-0d315b10828b)

# Store Attendant
For purchasing department, user should select Store Attendant in the Login Page.

![WhatsApp Image 2025-02-19 at 22 11 49 (1)](https://github.com/user-attachments/assets/7db2ec4d-ae87-4653-846e-300351ec3c39)

To see the data of products that is in the currently store, user can clik the list and the code will call the data from database and write in the upper boxes in the window. User can update the number of remaining products with clicking the button. 

![WhatsApp Image 2025-02-19 at 22 11 45 (1)](https://github.com/user-attachments/assets/ae247aef-e44f-41f5-a646-4daab032362d)

![WhatsApp Image 2025-02-19 at 22 11 45 (2)](https://github.com/user-attachments/assets/d96eb71a-dd59-4486-a996-bb5f245da145)

The expiration date of products is also changeable. Additionally, without selecting any product from the list, users can enter new data into the fields and click the Add New Product to Rayon button to add new products to the database.

![WhatsApp Image 2025-02-19 at 22 11 45](https://github.com/user-attachments/assets/6d4124ad-2557-4314-a20a-6594f1dcb551)

![WhatsApp Image 2025-02-19 at 22 11 45 (3)](https://github.com/user-attachments/assets/8d92e2fc-de51-4f39-9e2e-76b99e104fc2)

Additionally, the user can view expired products, as well as the cheapest and most expensive products in the rayon, by clicking the buttons at the bottom of the window. The user can scroll down to see the list of these products.

![WhatsApp Image 2025-02-19 at 22 11 46](https://github.com/user-attachments/assets/9e99b56e-1c9f-4ea2-85be-870165400105)

![WhatsApp Image 2025-02-19 at 22 11 46 (1)](https://github.com/user-attachments/assets/f6268c42-f931-4a19-8ebf-6c9733f6e063)

![WhatsApp Image 2025-02-19 at 22 11 46 (2)](https://github.com/user-attachments/assets/21ecaeed-abd8-4630-9df1-d5f71a361809)

