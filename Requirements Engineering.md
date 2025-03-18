# Trekster

Trekster is a simple and convenient personal finance tracking application designed to optimize and streamline the management of personal funds. Trekster allows users to manually enter data on expenses and income and also provides information grouped by categories and currencies.

## Functional Requirements

The application has two types of users: **authorized users** and **unauthorized users**  

### Unauthorized users can:
- Register
- Log in
- Reset the password

### Authorized users can:
- View a dashboard with key indicators (account balance, income and expense ratio, remaining funds)
- Set the reporting period (daily, weekly, monthly, yearly)
- Filter transactions by date, category, account, or amount
- Create a transaction (expense or income)
- View analytics of expenses and income in the form of charts (e.g., pie chart or bar chart)
- Export transaction data to a file (CSV, Excel)
- View their accounts and the balance of each account
- Add accounts
- View the transaction history
- Edit the transaction history
- View reports of income and expenses throughout the month
- Configure accounts and categories (delete and edit)
- Manage categories

## Non-Functional Requirements
- Interface language: Ukrainian (with the possibility of adding other languages in the future)
- Interface design: Static, without responsive design (non-responsive)
- The application must provide immediate feedback on user actions (less than 2 seconds for request processing)
- Stability: The application should maintain stable performance even with a large amount of data (thousands of transactions)
- The application should consume minimal system resources (CPU, RAM) to allow it to run on devices with medium technical specifications
- Scalability: The ability to work with a large number of accounts and transactions without performance degradation
- User interface: A simple and intuitive interface for users without experience with similar applications
- Data storage: Regular automatic saving of changes to the database to prevent data loss
- Compatibility: Compatibility with major file formats for export (CSV, Excel)

## Security Requirements
- **User Authentication**: The application should implement secure password hashing and session management to prevent unauthorized access.
- **Data Encryption**: Sensitive user data, such as passwords, account balances, and transaction data, should be encrypted both at rest and in transit.
- **User Privacy**: Personal data should only be visible to the respective user.
- **Account Lockout**: After multiple unsuccessful login attempts, the account should be temporarily locked.

## Performance Requirements
- **Request Processing Time**: All user actions should be processed within 2 seconds.
- **Maximum Data Load**: The application should support up to 10,000 transactions without performance degradation.
- **Concurrent Users**: The system should support at least 50 concurrent users without a significant performance drop.

## Backup and Data Recovery
- **Automatic Backups**: The application should perform daily backups.
- **Data Recovery**: There should be a recovery process in place to restore data from backups if needed.

## Localization
- **Multi-language Support**: The system should allow for easy addition of new languages.
- **Currency Support**: Users should be able to select and display transactions in different currencies.

## Testing Requirements
- **Unit Testing**: All core functions should be covered by unit tests.
- **Integration Testing**: Ensure all components work together seamlessly.
- **User Acceptance Testing**: The system should undergo UAT to confirm that it meets the functional and non-functional requirements.

## Accessibility
- **Keyboard Navigation**: All parts of the application should be navigable using a keyboard.
- **Screen Reader Support**: The application should support screen readers for visually impaired users.

# Roles

| Role                        | Description                                                                                                                   |
|-----------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| Authorized User             | Can edit data about their account, delete it. View the ratio of expenses to total income, and the balance to total income. Add, edit, and delete transactions. View their accounts and the balance of each. Add, edit, and delete accounts. View transaction history. View reports of income and expenses for the month, sorted by categories. Add, edit, and delete categories. |
| Non-Authorized User         | Can register, log in, reset the password.                                                                                      |

## Use case diagram

<p align="center">
	<img src="https://github.com/yvoznyak/Trekster_web/blob/main/docs/images/use.jpg" alt="Use case"/>
</p>

# Account Management System

| Use case          | Description                                                |
|-------------------|------------------------------------------------------------|
| Registration      | Register in the system (Create a new user)                |
| Login             | Log in to the system                                       |
| Logout            | Log out of the system                                      |
| Password Reset    | Change the user's password                                 |

# Finance Management System

| Use case                                                   | Description                                                                                                      |
|------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|
| View the ratio of expenses and balance to total income     | The user sees a chart showing the percentage share of total expenses and the balance from total income            |
| Add a transaction                                          | Add a transaction to the system, choosing its category, amount, currency, and account                            |
| View their accounts                                         | The user sees a list of all their accounts and their current balances                                             |
| Add an account                                             | The user can add an account to the system, entering the initial amount and currency                               |
| Delete an account                                          | The user can delete an account from the system and all transactions associated with it                           |
| View transaction history                                   | The user sees a list of all their transactions and information about them                                        |
| Edit transaction history                                   | The user can edit the category, amount, currency, account, and date of a transaction                             |
| View income and expense reports                            | The user sees reports grouped by categories                                                                     |
| View their categories                                       | The user sees a list of all their categories                                                                     |
| Add a category                                             | The user can add a category to the system, selecting its type                                                   |
| Edit a category                                            | The user can edit a category in the system                                                                       |
| Delete a category                                          | The user can delete a category from the system and all transactions associated with it                          |

