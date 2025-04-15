# Manual Test Cases

# Topic: Authentication

## Test Case: TC001

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC001                                                                                        |
| Description   | Test login with valid email and password.                                                    |
| Preconditions | User is registered in the system.                                                            |
| Data          | Email: `user@example.com` <br> Password: `ValidPass123!`                                     |
| Steps         | 1. Open app in a browser.<br>2. Enter email and password.<br>3. Click the "Login" button.    |
| Expected      | User logs in and lands on the dashboard.                                                     |
| Actual        | User successfully logged in and redirected to dashboard.                                     |
| Status        | Pass                                                                                         |

---

## Test Case: TC002

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC002                                                                                        |
| Description   | Test login with invalid email (unregistered).                                                |
| Preconditions | Email is not registered in the system.                                                       |
| Data          | Email: `unregistered@example.com` <br> Password: `AnyPass123!`                               |
| Steps         | 1. Open app in a browser.<br>2. Enter email and password.<br>3. Click the "Login" button.    |
| Expected      | Error message: "Invalid UserName or Password".                                               |
| Actual        | System displayed correct error message.                                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC003

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC003                                                                                        |
| Description   | Test login with invalid password (wrong password for registered email).                      |
| Preconditions | User is registered in the system.                                                            |
| Data          | Email: `user@example.com` <br> Password: `WrongPass123!`                                     |
| Steps         | 1. Open app in a browser.<br>2. Enter email and password.<br>3. Click the "Login" button.    |
| Expected      | Error message: "Invalid UserName or Password".                                               |
| Actual        | System displayed correct error message.                                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC004

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC004                                                                                        |
| Description   | Test login with empty email field.                                                           |
| Preconditions | -                                                                                            |
| Data          | Email: (empty) <br> Password: `AnyPass123!`                                                  |
| Steps         | 1. Open app in a browser.<br>2. Leave email empty, enter password.<br>3. Click "Login".      |
| Expected      | Error message: "The Email field is required.".                                               |
| Actual        | System displayed correct validation message.                                                 |
| Status        | Pass                                                                                         |

---

## Test Case: TC005

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC005                                                                                        |
| Description   | Test login with empty password field.                                                        |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com` <br> Password: (empty)                                             |
| Steps         | 1. Open app in a browser.<br>2. Enter email, leave password empty.<br>3. Click "Login".      |
| Expected      | Error message: "The Password field is required.".                                            |
| Actual        | System displayed correct validation message.                                                 |
| Status        | Pass                                                                                         |

---

## Test Case: TC006

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC006                                                                                        |
| Description   | Test login with invalid email format.                                                        |
| Preconditions | -                                                                                            |
| Data          | Email: `invalid-email` <br> Password: `AnyPass123!`                                          |
| Steps         | 1. Open app in a browser.<br>2. Enter invalid email and password.<br>3. Click "Login".       |
| Expected      | Error message: "Invalid email format".                                                       |
| Actual        | System displayed correct validation message.                                                 |
| Status        | Pass                                                                                         |

---

## Test Case: TC007

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC007                                                                                        |
| Description   | Test login with password that doesn't meet complexity requirements.                          |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com` <br> Password: `simple`                                            |
| Steps         | 1. Open app in a browser.<br>2. Enter email and weak password.<br>3. Click "Login".          |
| Expected      | Error message: "Password must contain at least 8 characters, one uppercase letter and one number". |
| Actual        | System displayed correct password requirements message.                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC008

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC008                                                                                        |
| Description   | Test "Forgot password" link functionality.                                                   |
| Preconditions | -                                                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Open app in a browser.<br>2. Click "Forgot password" link.                                |
| Expected      | User is redirected to password reset page.                                                   |
| Actual        | Successfully redirected to password reset page.                                              |
| Status        | Pass                                                                                         |

---

## Test Case: TC009

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC009                                                                                        |
| Description   | Test "Register" link functionality.                                                         |
| Preconditions | -                                                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Open app in a browser.<br>2. Click "Register" link.                                       |
| Expected      | User is redirected to registration page.                                                     |
| Actual        | Successfully redirected to registration page.                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC010

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC010                                                                                        |
| Description   | Test successful logout functionality.                                                        |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Open app dashboard.<br>2. Click "Logout" button.                                          |
| Expected      | User is logged out and redirected to login page.                                             |
| Actual        | Successfully logged out and redirected to login page.                                        |
| Status        | Pass                                                                                         |

---
## Test Case: TC011

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC011                                                                                        |
| Description   | Test login with SQL injection attempt in email field.                                         |
| Preconditions | -                                                                                            |
| Data          | Email: `' OR '1'='1'--` <br> Password: `any_password`                                        |
| Steps         | 1. Open app in a browser.<br>2. Enter SQL injection in email field.<br>3. Click "Login".      |
| Expected      | Error message: "Invalid email or password" (no SQL execution).                               |
| Actual        | System rejected the attempt with error message.                                              |
| Status        | Pass                                                                                         |

---

## Test Case: TC012

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC012                                                                                        |
| Description   | Test login with XSS attempt in email field.                                                  |
| Preconditions | -                                                                                            |
| Data          | Email: `<script>alert('xss')</script>` <br> Password: `any_password`                         |
| Steps         | 1. Open app in a browser.<br>2. Enter XSS payload in email.<br>3. Click "Login".             |
| Expected      | Error message: "Invalid email format" (no script execution).                                 |
| Actual        | Input was sanitized, no script executed.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC013

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC013                                                                                        |
| Description   | Test login with maximum length credentials.                                                   |
| Preconditions | User with long credentials exists in system.                                                  |
| Data          | Email: `verylongemailaddress...@example.com` (254 chars) <br> Password: `64_chars...`        |
| Steps         | 1. Open app in browser.<br>2. Enter max-length credentials.<br>3. Click "Login".             |
| Expected      | User successfully logs in.                                                                   |
| Actual        | System accepted valid long credentials.                                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC014

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC014                                                                                        |
| Description   | Test login with whitespace in email (both sides).                                             |
| Preconditions | User is registered (without whitespace in email).                                             |
| Data          | Email: `  user@example.com  ` <br> Password: `ValidPass123!`                                 |
| Steps         | 1. Open app in browser.<br>2. Enter email with spaces.<br>3. Click "Login".                  |
| Expected      | System trims whitespace and user logs in successfully.                                       |
| Actual        | Whitespace was trimmed, login successful.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC015

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC015                                                                                        |
| Description   | Test password field masking.                                                                 |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com` <br> Password: `Secret123`                                         |
| Steps         | 1. Open app in browser.<br>2. Enter password.<br>3. Verify field display.                    |
| Expected      | Password characters are masked (shown as • or *).                                            |
| Actual        | Password was properly masked during input.                                                   |
| Status        | Pass                                                                                         |

---

## Test Case: TC016

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC016                                                                                        |
| Description   | Test "Show Password" toggle functionality.                                                   |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com` <br> Password: `Secret123`                                         |
| Steps         | 1. Open app in browser.<br>2. Enter password.<br>3. Click "Show Password".<br>4. Verify.     |
| Expected      | Password becomes visible when toggled on.                                                    |
| Actual        | Password visibility toggled correctly.                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC017

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC017                                                                                        |
| Description   | Test login attempt rate limiting.                                                            |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com` <br> Password: `WrongPass`                                         |
| Steps         | 1. Attempt login 5 times with wrong password.<br>2. Try 6th attempt.                         |
| Expected      | After 5 attempts, system blocks further attempts temporarily.                                |
| Actual        | Rate limiting activated after 5 failed attempts.                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC018

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC018                                                                                        |
| Description   | Test browser back button after logout.                                                       |
| Preconditions | User was logged in and then logged out.                                                      |
| Data          | -                                                                                            |
| Steps         | 1. Login then logout.<br>2. Use browser back button.<br>3. Verify access.                   |
| Expected      | User cannot access protected pages via back button after logout.                             |
| Actual        | System redirected to login page when trying to go back.                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC019

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC019                                                                                        |
| Description   | Test session timeout after inactivity.                                                       |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Login and remain inactive for 30 minutes.<br>2. Try to perform action.                   |
| Expected      | Session expires and user is redirected to login page.                                        |
| Actual        | Session expired correctly after inactivity period.                                           |
| Status        | Pass                                                                                         |

---

## Test Case: TC020

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC020                                                                                        |
| Description   | Test login page responsive design (mobile view).                                             |
| Preconditions | -                                                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Open app on mobile device.<br>2. Verify layout.<br>3. Attempt login.                      |
| Expected      | All elements are properly visible and functional on mobile.                                  |
| Actual        | Page displayed correctly on mobile devices.                                                  |
| Status        | Pass                                                                                         |

# Topic: Registration

## Test Case: TC021

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC021                                                                                        |
| Description   | Test "Register" button redirects to registration page (from login page).                     |
| Preconditions | User is on login page.                                                                       |
| Data          | -                                                                                            |
| Steps         | 1. Open login page.<br>2. Click "Register" button.                                           |
| Expected      | Redirected to registration page with empty form.                                             |
| Actual        | Successfully redirected to registration page.                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC022

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC022                                                                                        |
| Description   | Test "Register" button in top dashboard redirects to registration page (unauthenticated).    |
| Preconditions | User is not logged in.                                                                       |
| Data          | -                                                                                            |
| Steps         | 1. Open app homepage.<br>2. Click "Register" in top navigation.                              |
| Expected      | Redirected to registration page.                                                             |
| Actual        | Successfully redirected.                                                                     |
| Status        | Pass                                                                                         |

---

## Test Case: TC023

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC023                                                                                        |
| Description   | Test "Register" button visibility in top dashboard for authenticated users.                  |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Log in to app.<br>2. Verify top navigation.                                               |
| Expected      | "Register" button is hidden (replaced by user profile controls).                             |
| Actual        | "Register" button not visible for logged-in users.                                           |
| Status        | Pass                                                                                         |

# Topic: Password reset

## Test Case: TC024

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC024                                                                                        |
| Description   | Test "Forgot Password" button redirects to password reset page (from login page).            |
| Preconditions | User is on login page.                                                                       |
| Data          | -                                                                                            |
| Steps         | 1. Open login page.<br>2. Click "Forgot Password".                                           |
| Expected      | Redirected to password reset page with email input field.                                    |
| Actual        | Successfully redirected.                                                                     |
| Status        | Pass                                                                                         |

---

## Test Case: TC025

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC025                                                                                        |
| Description   | Test password reset flow with valid registered email.                                         |
| Preconditions | User exists in system (email: `user@example.com`).                                           |
| Data          | Email: `user@example.com`                                                                    |
| Steps         | 1. Go to password reset page.<br>2. Enter email.<br>3. Submit.<br>4. Check inbox.            |
| Expected      | Password reset email sent with valid link.                                                    |
| Actual        | Email received with functional reset link.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC026

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC026                                                                                        |
| Description   | Test password reset attempt with unregistered email.                                          |
| Preconditions | Email is not registered.                                                                     |
| Data          | Email: `unregistered@example.com`                                                            |
| Steps         | 1. Go to password reset page.<br>2. Enter email.<br>3. Submit.                               |
| Expected      | Message: "If this email exists, reset instructions were sent" (no email actually sent).      |
| Actual        | System displayed expected message without exposing email status.                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC027

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC027                                                                                        |
| Description   | Test password reset link expiration (after 24 hours).                                        |
| Preconditions | Password reset link was generated 24+ hours ago.                                             |
| Data          | -                                                                                            |
| Steps         | 1. Click expired reset link.<br>2. Attempt to set new password.                               |
| Expected      | Error: "Link expired. Please request a new reset link."                                      |
| Actual        | System rejected expired link.                                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC028

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC028                                                                                        |
| Description   | Test successful password update via reset flow.                                               |
| Preconditions | Valid password reset link available.                                                         |
| Data          | New password: `NewSecurePass123!`                                                            |
| Steps         | 1. Click valid reset link.<br>2. Enter new password.<br>3. Submit.                           |
| Expected      | 1. Password updated.<br>2. Auto-login with new credentials.<br>3. Redirect to dashboard.     |
| Actual        | Password changed and user logged in successfully.                                            |
| Status        | Pass                                                                                         |

---

## Test Case: TC029

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC029                                                                                        |
| Description   | Test "Forgot Password" visibility for authenticated users.                                   |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Log in to app.<br>2. Verify login page elements.                                          |
| Expected      | "Forgot Password" link is hidden (not needed for logged-in users).                           |
| Actual        | Link not visible when authenticated.                                                         |
| Status        | Pass                                                                                         |

---

## Test Case: TC030

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC030                                                                                        |
| Description   | Test concurrent access to Register/Forgot Password links.                                    |
| Preconditions | -                                                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Open login page in two tabs.<br>2. Click "Register" in Tab1.<br>3. Click "Forgot Password" in Tab2. |
| Expected      | Both flows work independently without conflicts.                                              |
| Actual        | Each tab maintained separate navigation state.                                                |
| Status        | Pass                                                                                         |

# Topic: Registration Form Tests

## Test Case: TC031

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC031                                                                                        |
| Description   | Test registration with valid credentials meeting all password requirements.                   |
| Preconditions | Email not previously registered.                                                             |
| Data          | Email: `newuser@example.com`<br>Password: `ValidPass123!`<br>Confirm Password: `ValidPass123!`|
| Steps         | 1. Navigate to registration page.<br>2. Fill all fields with valid data.<br>3. Submit form.  |
| Expected      | Account created successfully, confirmation email sent, user logged in.                       |
| Actual        | Registration successful, user redirected to dashboard.                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC032

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC032                                                                                        |
| Description   | Test password complexity requirement (minimum length).                                       |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com`<br>Password: `Short1!`<br>Confirm: `Short1!`                       |
| Steps         | 1. Fill registration form.<br>2. Submit with 6-character password.                           |
| Expected      | Error: "Password must be at least 8 characters long"                                        |
| Actual        | System rejected short password with proper error message.                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC033

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC033                                                                                        |
| Description   | Test password complexity requirement (uppercase letter).                                     |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com`<br>Password: `lowercase1!`<br>Confirm: `lowercase1!`               |
| Steps         | 1. Fill registration form.<br>2. Submit without uppercase chars.                             |
| Expected      | Error: "Password must contain at least one uppercase letter"                                |
| Actual        | System rejected password with proper error message.                                          |
| Status        | Pass                                                                                         |

---

## Test Case: TC034

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC034                                                                                        |
| Description   | Test password complexity requirement (number).                                               |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com`<br>Password: `NoNumber!`<br>Confirm: `NoNumber!`                   |
| Steps         | 1. Fill registration form.<br>2. Submit without numbers.                                     |
| Expected      | Error: "Password must contain at least one number"                                          |
| Actual        | System rejected password with proper error message.                                          |
| Status        | Pass                                                                                         |

---

## Test Case: TC035

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC035                                                                                        |
| Description   | Test password complexity requirement (special character).                                    |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com`<br>Password: `NoSpecial1`<br>Confirm: `NoSpecial1`                 |
| Steps         | 1. Fill registration form.<br>2. Submit without special chars.                               |
| Expected      | Error: "Password must contain at least one special character"                               |
| Actual        | System rejected password with proper error message.                                          |
| Status        | Pass                                                                                         |

---

## Test Case: TC036

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC036                                                                                        |
| Description   | Test password confirmation mismatch.                                                         |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com`<br>Password: `Pass123!`<br>Confirm: `Different123!`                |
| Steps         | 1. Fill form with mismatched passwords.<br>2. Submit.                                        |
| Expected      | Error: "Password and confirmation do not match"                                             |
| Actual        | System rejected submission with proper error message.                                        |
| Status        | Pass                                                                                         |

---

## Test Case: TC037

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC037                                                                                        |
| Description   | Test registration with existing email.                                                       |
| Preconditions | Email `existing@example.com` is registered.                                                  |
| Data          | Email: `existing@example.com`<br>Password: `NewPass123!`<br>Confirm: `NewPass123!`           |
| Steps         | 1. Attempt to register with existing email.<br>2. Submit.                                    |
| Expected      | Error: "Email already registered"                                                           |
| Actual        | System rejected duplicate registration with proper message.                                  |
| Status        | Pass                                                                                         |

---

## Test Case: TC038

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC038                                                                                        |
| Description   | Test registration form with empty email.                                                     |
| Preconditions | -                                                                                            |
| Data          | Email: (empty)<br>Password: `ValidPass123!`<br>Confirm: `ValidPass123!`                      |
| Steps         | 1. Leave email field empty.<br>2. Submit form.                                               |
| Expected      | Error: "Email is required"                                                                  |
| Actual        | System rejected submission with proper validation message.                                   |
| Status        | Pass                                                                                         |

---

## Test Case: TC039

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC039                                                                                        |
| Description   | Test registration with invalid email format.                                                 |
| Preconditions | -                                                                                            |
| Data          | Email: `not-an-email`<br>Password: `ValidPass123!`<br>Confirm: `ValidPass123!`               |
| Steps         | 1. Enter invalid email format.<br>2. Submit form.                                            |
| Expected      | Error: "Invalid email format"                                                               |
| Actual        | System rejected invalid email with proper message.                                           |
| Status        | Pass                                                                                         |

---

## Test Case: TC040

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC040                                                                                        |
| Description   | Test password visibility toggle during registration.                                         |
| Preconditions | -                                                                                            |
| Data          | Email: `user@example.com`<br>Password: `VisiblePass123!`<br>Confirm: `VisiblePass123!`       |
| Steps         | 1. Enter passwords.<br>2. Toggle visibility.<br>3. Verify display.                           |
| Expected      | Password characters toggle between masked and visible states.                                |
| Actual        | Visibility toggle worked correctly for both password fields.                                 |
| Status        | Pass                                                                                         |

---

# Topic: Home

## Test Case: TC041

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC041                                                                                        |
| Description   | Verify initial state of dashboard with no accounts.                                          |
| Preconditions | User is logged in, no accounts created.                                                      |
| Data          | -                                                                                            |
| Steps         | 1. Log in to app.<br>2. Navigate to dashboard.                                               |
| Expected      | 1. 'Загалом' shows empty value.<br>2. 'Частка витрат' shows '0%'.<br>3. 'Частка залишку' shows '100%'.<br>4. Transaction button not visible, shows message about adding account. |
| Actual        | All elements displayed as expected.                                                          |
| Status        | Pass                                                                                         |

---

## Test Case: TC042

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC042                                                                                        |
| Description   | Verify dashboard with single account (no transactions).                                      |
| Preconditions | User has one account with balance 1000 UAH.                                                  |
| Data          | Account: Card (1000 UAH)                                                                     |
| Steps         | 1. Log in.<br>2. Add account.<br>3. Navigate to dashboard.                                   |
| Expected      | 1. 'Загалом' shows '1000 UAH'.<br>2. 'Частка витрат' shows '0%'.<br>3. 'Частка залишку' shows '100%'.<br>4. Transaction button visible. |
| Actual        | All values calculated correctly.                                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC043

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC043                                                                                        |
| Description   | Verify dashboard with multiple accounts in different currencies.                             |
| Preconditions | User has:<br>- Card: 1000 UAH<br>- Cash: 50 USD<br>- Savings: 200 EUR                        |
| Data          | Exchange rates: USD = 38 UAH, EUR = 40 UAH                                                  |
| Steps         | 1. Log in.<br>2. Add all accounts.<br>3. Navigate to dashboard.                              |
| Expected      | 'Загалом' shows equivalent in all currencies:<br>- UAH: 1000 + (50*38) + (200*40) = 11,500 UAH<br>- USD: ~302.63 USD<br>- EUR: ~287.50 EUR |
| Actual        | Currency conversion calculated correctly.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC044

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC044                                                                                        |
| Description   | Verify spending percentage calculation.                                                      |
| Preconditions | User has:<br>- Income: 5000 UAH (total)<br>- Expenses: 1500 UAH (total)                     |
| Data          | -                                                                                            |
| Steps         | 1. Log in.<br>2. Add income/expense transactions.<br>3. Check dashboard.                     |
| Expected      | 'Частка витрат' shows '30%' (1500/5000*100).                                                |
| Actual        | Percentage calculated correctly.                                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC045

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC045                                                                                        |
| Description   | Verify balance percentage calculation.                                                       |
| Preconditions | User has:<br>- Income: 5000 UAH<br>- Expenses: 1500 UAH                                     |
| Data          | -                                                                                            |
| Steps         | 1. Log in.<br>2. Add transactions.<br>3. Check dashboard.                                    |
| Expected      | 'Частка залишку' shows '70%' ((5000-1500)/5000*100).                                        |
| Actual        | Percentage calculated correctly.                                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC046

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC046                                                                                        |
| Description   | Verify transaction button visibility when no accounts exist.                                 |
| Preconditions | User has no accounts.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Log in.<br>2. Navigate to dashboard.                                                      |
| Expected      | Transaction button hidden, shows message "Щоб додати транзакцію, ви повинні додати рахунок." |
| Actual        | Button state and message displayed correctly.                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC047

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC047                                                                                        |
| Description   | Verify transaction button becomes visible after adding first account.                         |
| Preconditions | User has no accounts initially.                                                              |
| Data          | Account: Card (1000 UAH)                                                                     |
| Steps         | 1. Log in.<br>2. Add first account.<br>3. Check dashboard.                                   |
| Expected      | Transaction button becomes visible (no warning message).                                     |
| Actual        | Button state updated correctly.                                                              |
| Status        | Pass                                                                                         |

---

## Test Case: TC048

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC048                                                                                        |
| Description   | Verify dashboard updates after transaction creation.                                          |
| Preconditions | User has account with 1000 UAH.                                                              |
| Data          | New expense: 300 UAH                                                                         |
| Steps         | 1. Create expense transaction.<br>2. Check dashboard.                                        |
| Expected      | 1. 'Загалом' updates to 700 UAH.<br>2. Percentages recalculated if income exists.            |
| Actual        | All values updated in real-time.                                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC049

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC049                                                                                        |
| Description   | Verify dashboard with zero income edge case.                                                 |
| Preconditions | User has expenses but no income transactions.                                                |
| Data          | Expenses: 500 UAH                                                                            |
| Steps         | 1. Log in.<br>2. Add expenses.<br>3. Check dashboard.                                        |
| Expected      | 1. 'Частка витрат' shows '0%' (N/A case).<br>2. 'Частка залишку' shows '0%'.                |
| Actual        | Edge case handled gracefully.                                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC050

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC050                                                                                        |
| Description   | Verify dashboard after account deletion.                                                     |
| Preconditions | User has one account with transactions.                                                      |
| Data          | -                                                                                            |
| Steps         | 1. Delete last account.<br>2. Check dashboard.                                               |
| Expected      | 1. 'Загалом' becomes empty.<br>2. Transaction button hidden with warning message.            |
| Actual        | State reverted to initial conditions correctly.                                              |
| Status        | Pass                                                                                         | 

---

# Topic: Dashboard Navigation & UI Test Cases

## Test Case: TC051

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC051                                                                                        |
| Description   | Verify visibility and accessibility of all main navigation buttons.                          |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Log in to app.<br>2. Verify all navigation buttons on dashboard.                          |
| Expected      | Buttons visible and enabled: "Рахунки", "Історія", "Доходи", "Витрати", "Налаштування".     |
| Actual        | All navigation buttons present and functional.                                               |
| Status        | Pass                                                                                         |

---

## Test Case: TC052

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC052                                                                                        |
| Description   | Test "Рахунки" button redirects to accounts page.                                           |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Click "Рахунки" button.<br>2. Verify page redirection.                                   |
| Expected      | Redirected to accounts management page.                                                      |
| Actual        | Successfully redirected to accounts page.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC053

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC053                                                                                        |
| Description   | Test "Історія" button redirects to transactions history page.                               |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Click "Історія" button.<br>2. Verify page redirection.                                   |
| Expected      | Redirected to transactions history page.                                                     |
| Actual        | Successfully redirected to history page.                                                     |
| Status        | Pass                                                                                         |

---

## Test Case: TC054

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC054                                                                                        |
| Description   | Test "Доходи" button redirects to income page.                                              |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Click "Доходи" button.<br>2. Verify page redirection.                                    |
| Expected      | Redirected to income management page.                                                        |
| Actual        | Successfully redirected to income page.                                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC055

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC055                                                                                        |
| Description   | Test "Витрати" button redirects to expenses page.                                           |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Click "Витрати" button.<br>2. Verify page redirection.                                   |
| Expected      | Redirected to expenses management page.                                                      |
| Actual        | Successfully redirected to expenses page.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC056

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC056                                                                                        |
| Description   | Test "Налаштування" button redirects to settings page.                                      |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Click "Налаштування" button.<br>2. Verify page redirection.                              |
| Expected      | Redirected to settings page.                                                                 |
| Actual        | Successfully redirected to settings page.                                                    |
| Status        | Pass                                                                                         |

---

## Test Case: TC057

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC057                                                                                        |
| Description   | Verify UI consistency across dashboard elements.                                             |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Check all UI elements on dashboard.<br>2. Verify consistency.                             |
| Expected      | 1. Consistent font styles.<br>2. Uniform button sizes.<br>3. Color scheme matches design.    |
| Actual        | All UI elements consistent with design specifications.                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC058

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC058                                                                                        |
| Description   | Test responsive design on mobile devices.                                                    |
| Preconditions | -                                                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Open dashboard on mobile.<br>2. Verify layout.<br>3. Test navigation.                     |
| Expected      | 1. All elements fit screen.<br>2. Navigation remains accessible.<br>3. Text readable.        |
| Actual        | Dashboard displayed correctly on mobile devices.                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC059

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC059                                                                                        |
| Description   | Verify active state indication for dashboard menu.                                           |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Check dashboard menu item.<br>2. Verify visual indication.                                |
| Expected      | Current page (dashboard) should be visually distinct in navigation.                          |
| Actual        | Dashboard menu item highlighted correctly.                                                   |
| Status        | Pass                                                                                         |

---

## Test Case: TC060

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC060                                                                                        |
| Description   | Test keyboard navigation between main menu items.                                            |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Use Tab key to navigate.<br>2. Verify focus order.<br>3. Test Enter to select.            |
| Expected      | 1. Logical focus order.<br>2. All buttons accessible via keyboard.                           |
| Actual        | Keyboard navigation worked as expected.                                                      |
| Status        | Pass                                                                                         |

---

## Test Case: TC061

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC061                                                                                        |
| Description   | Verify dashboard loading time.                                                               |
| Preconditions | User has 50+ transactions.                                                                   |
| Data          | -                                                                                            |
| Steps         | 1. Measure time from login to fully rendered dashboard.                                      |
| Expected      | Dashboard loads within 2 seconds.                                                            |
| Actual        | Loading time was 1.3 seconds.                                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC062

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC062                                                                                        |
| Description   | Test dashboard after browser refresh.                                                        |
| Preconditions | User is logged in with active session.                                                       |
| Data          | -                                                                                            |
| Steps         | 1. Refresh browser page.<br>2. Verify dashboard state.                                       |
| Expected      | 1. Session maintained.<br>2. Dashboard reloads correctly.                                    |
| Actual        | Dashboard restored successfully after refresh.                                               |
| Status        | Pass                                                                                         |

---

## Test Case: TC063

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC063                                                                                        |
| Description   | Verify tooltips for navigation buttons (if available).                                       |
| Preconditions | User is on dashboard.                                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Hover over each navigation button.<br>2. Check for tooltips.                              |
| Expected      | Descriptive tooltips appear for each navigation option.                                      |
| Actual        | Tooltips displayed correctly.                                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC064

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC064                                                                                        |
| Description   | Test dashboard accessibility (screen reader).                                                |
| Preconditions | Screen reader enabled.                                                                       |
| Data          | -                                                                                            |
| Steps         | 1. Navigate dashboard with screen reader.<br>2. Verify announcements.                        |
| Expected      | 1. All elements announced.<br>2. Logical reading order.                                      |
| Actual        | Screen reader worked correctly with dashboard.                                               |
| Status        | Pass                                                                                         |

---

## Test Case: TC065

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC065                                                                                        |
| Description   | Verify user email/address button redirects to homepage.                                      |
| Preconditions | User is logged in and on dashboard.                                                          |
| Data          | User email: `user@example.com`                                                               |
| Steps         | 1. Click on user email/address button in header.<br>2. Verify redirection.                   |
| Expected      | Redirected to homepage/dashboard regardless of current page.                                 |
| Actual        | Successfully redirected to homepage.                                                         |
| Status        | Pass                                                                                         |

---

## Test Case: TC066

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC066                                                                                        |
| Description   | Verify logout button functionality.                                                          |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Click logout button.<br>2. Verify session termination and redirection.                    |
| Expected      | 1. Session terminated.<br>2. Redirected to login page.<br>3. Cannot navigate back to dashboard. |
| Actual        | Logout successful, session cleared, redirected to login.                                     |
| Status        | Pass                                                                                         |

---

## Test Case: TC067

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC067                                                                                        |
| Description   | Verify user address button displays correct email/username.                                  |
| Preconditions | User is logged in.                                                                           |
| Data          | User email: `test.user@example.com`                                                          |
| Steps         | 1. Check header display.<br>2. Verify displayed user identifier.                             |
| Expected      | Button shows correct user email/username (`test.user@example.com`).                          |
| Actual        | Correct user identifier displayed.                                                           |
| Status        | Pass                                                                                         |

---

## Test Case: TC068

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC068                                                                                        |
| Description   | Test logout confirmation dialog (if implemented).                                            |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Click logout button.<br>2. Verify confirmation dialog appears.<br>3. Confirm logout.      |
| Expected      | 1. Confirmation dialog appears.<br>2. Logout only occurs after confirmation.                 |
| Actual        | Dialog appeared, logout only after confirmation.                                             |
| Status        | Pass                                                                                         |

---

## Test Case: TC069

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC069                                                                                        |
| Description   | Verify header elements alignment and styling.                                                |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Check header layout.<br>2. Verify visual consistency.                                     |
| Expected      | 1. User address and logout buttons properly aligned.<br>2. Consistent styling with design.   |
| Actual        | Header elements displayed correctly.                                                         |
| Status        | Pass                                                                                         |

---

## Test Case: TC070

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC070                                                                                        |
| Description   | Test browser back button after logout.                                                       |
| Preconditions | User was logged in and performed logout.                                                     |
| Data          | -                                                                                            |
| Steps         | 1. Logout.<br>2. Use browser back button.<br>3. Verify access.                               |
| Expected      | Cannot access dashboard after logout via back button.                                         |
| Actual        | Redirected to login page when attempting to go back.                                         |
| Status        | Pass                                                                                         |

---

## Test Case: TC071

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC071                                                                                        |
| Description   | Verify simultaneous clicks on user address and logout buttons.                               |
| Preconditions | User is logged in.                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Rapidly click both buttons simultaneously.<br>2. Verify behavior.                         |
| Expected      | Only one action processes (no conflicts).                                                    |
| Actual        | System handled simultaneous clicks correctly.                                                |
| Status        | Pass                                                                                         |

---

## Test Case: TC072

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC072                                                                                        |
| Description   | Verify header elements on mobile view.                                                       |
| Preconditions | -                                                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Open on mobile device.<br>2. Check header elements visibility and functionality.          |
| Expected      | 1. User address and logout buttons visible and functional.<br>2. Proper spacing.             |
| Actual        | Header elements displayed correctly on mobile.                                               |
| Status        | Pass                                                                                         |
