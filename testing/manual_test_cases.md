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

# Topic: Accounts

## Test Case: TC073

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC073                                                                                        |
| Description   | Перевірка початкового стану сторінки "Рахунки" без доданих рахунків                         |
| Preconditions | Користувач авторизований, рахунків немає                                                    |
| Data          | -                                                                                            |
| Steps         | 1. Перейти на сторінку "Рахунки"                                                             |
| Expected      | 1. Відображається лише кнопка "Додати рахунок"<br>2. Список рахунків порожній               |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC074

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC074                                                                                        |
| Description   | Перевірка відкриття форми додавання рахунку                                                  |
| Preconditions | Користувач на сторінці "Рахунки"                                                            |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Додати рахунок"<br>2. Перевірити форму                                        |
| Expected      | Форма містить:<br>- Поле "Назва" (обов'язкове)<br>- Поля балансів (UAH, USD, EUR, USDT, BTC) зі значенням 0<br>- Кнопки "Додати" та "Назад до переліку" |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC075

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC075                                                                                        |
| Description   | Додавання рахунку з мінімальними даними (тільки назва)                                       |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: "Основний рахунок"<br>Всі баланси: 0                                                  |
| Steps         | 1. Ввести назву<br>2. Натиснути "Додати"                                                     |
| Expected      | 1. Рахунок додано<br>2. Повернення на сторінку "Рахунки"<br>3. У списку відображається новий рахунок з правильною назвою та нульовими балансами |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC076

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC076                                                                                        |
| Description   | Додавання рахунку з усіма типами балансів                                                    |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: "Мультивалютний"<br>UAH: 1000<br>USD: 50<br>EUR: 0<br>USDT: 200<br>BTC: 0.005         |
| Steps         | 1. Заповнити всі поля<br>2. Натиснути "Додати"                                               |
| Expected      | 1. Рахунок додано<br>2. У списку відображається з правильними значеннями всіх балансів       |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC077

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC077                                                                                        |
| Description   | Скасування додавання рахунку (кнопка "Назад до переліку")                                    |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: "Тестовий"<br>UAH: 500                                                                |
| Steps         | 1. Заповнити поля<br>2. Натиснути "Назад до переліку"                                        |
| Expected      | 1. Форма закривається<br>2. Рахунок не додано<br>3. Повернення на сторінку "Рахунки" без змін |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC078

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC078                                                                                        |
| Description   | Спроба додати рахунок без назви                                                              |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: (порожнє)<br>UAH: 1000                                                               |
| Steps         | 1. Залишити назву порожньою<br>2. Натиснути "Додати"                                         |
| Expected      | 1. Помилка валідації "Назва обов'язкова"<br>2. Форма не закривається                        |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC079

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC079                                                                                        |
| Description   | Введення від'ємних значень у поля балансів                                                   |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: "Тест"<br>UAH: -100                                                                   |
| Steps         | 1. Ввести від'ємне значення<br>2. Натиснути "Додати"                                         |
| Expected      | 1. Помилка валідації "Баланс не може бути від'ємним"<br>2. Форма не закривається            |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC080

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC080                                                                                        |
| Description   | Введення нечислових значень у поля балансів                                                  |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: "Тест"<br>USD: "сто"                                                                  |
| Steps         | 1. Ввести текст у поле балансу<br>2. Натиснути "Додати"                                      |
| Expected      | 1. Помилка валідації "Введіть числове значення"<br>2. Форма не закривається                 |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC081

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC081                                                                                        |
| Description   | Перевірка відображення рахунків після проведення транзакцій                                  |
| Preconditions | Є рахунок "Готівка" з початковим балансом: UAH 1000                                         |
| Data          | Доход: +500 UAH<br>Витрата: -300 UAH                                                         |
| Steps         | 1. Провести транзакції<br>2. Перевірити сторінку "Рахунки"                                   |
| Expected      | Рахунок відображає поточний баланс: 1200 UAH (1000 + 500 - 300)                              |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC082

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC082                                                                                        |
| Description   | Перевірка сортування рахунків у списку                                                       |
| Preconditions | Є 3 рахунки: "Банк", "Готівка", "Крипто"                                                     |
| Data          | -                                                                                            |
| Steps         | 1. Перейти на сторінку "Рахунки"                                                             |
| Expected      | Рахунки відсортовані за алфавітом (Банк, Готівка, Крипто)                                    |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC083

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC083                                                                                        |
| Description   | Перевірка відображення рахунків з різними валютами                                           |
| Preconditions | Є рахунки з балансами в різних валютах                                                       |
| Data          | -                                                                                            |
| Steps         | 1. Перейти на сторінку "Рахунки"                                                             |
| Expected      | Кожен рахунок відображає:<br>- Назву<br>- Баланси по всіх валютах (нульові приховані)        |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC084

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC084                                                                                        |
| Description   | Перевірка обмеження довжини назви рахунку                                                    |
| Preconditions | Форма додавання рахунку відкрита                                                             |
| Data          | Назва: "Дуже довга назва рахунку яка перевищує ліміт символів" (більше 50 символів)          |
| Steps         | 1. Ввести довгу назву<br>2. Натиснути "Додати"                                               |
| Expected      | 1. Помилка "Максимальна довжина назви 50 символів"<br>2. Форма не закривається              |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC085

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC085                                                                                        |
| Description   | Перевірка унікальності назви рахунку                                                         |
| Preconditions | Вже існує рахунок з назвою "Основний"                                                       |
| Data          | Назва: "Основний"                                                                            |
| Steps         | 1. Спробувати додати рахунок з існуючою назвою<br>2. Натиснути "Додати"                      |
| Expected      | 1. Помилка "Рахунок з такою назвою вже існує"<br>2. Форма не закривається                   |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

# Topic: Settings

# Тест-кейси для сторінки "Налаштування"

## Розділ "Рахунки"

### Test Case: TC086

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC086                                                                                        |
| Description   | Перевірка початкового стану розділу "Рахунки"                                               |
| Preconditions | Користувач авторизований, рахунків немає                                                    |
| Data          | -                                                                                            |
| Steps         | 1. Перейти у "Налаштування" → "Рахунки"                                                      |
| Expected      | Відображається повідомлення "Рахунків не знайдено"                                          |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC087

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC087                                                                                        |
| Description   | Перевірка відображення доданих рахунків                                                      |
| Preconditions | Є 2 активні рахунки                                                                          |
| Data          | -                                                                                            |
| Steps         | 1. Перейти у розділ "Рахунки"                                                                |
| Expected      | Відображається список рахунків з кнопками "Редагувати" та "Видалити" для кожного             |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC088

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC088                                                                                        |
| Description   | Зміна назви рахунку                                                                          |
| Preconditions | Є рахунок "Основний"                                                                         |
| Data          | Нова назва: "Основний банківський"                                                           |
| Steps         | 1. Натиснути "Редагувати"<br>2. Змінити назву<br>3. Зберегти                                 |
| Expected      | 1. Назва змінена у списку<br>2. Зміни відображаються на всіх сторінках додатку              |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC089

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC089                                                                                        |
| Description   | Спроба зберегти порожню назву рахунку                                                        |
| Preconditions | Відкрито форму редагування рахунку                                                           |
| Data          | Назва: (порожнє)                                                                            |
| Steps         | 1. Очистити поле назви<br>2. Спробувати зберегти                                             |
| Expected      | 1. Помилка "Назва обов'язкова"<br>2. Форма не закривається                                  |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC090

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC090                                                                                        |
| Description   | Видалення рахунку                                                                            |
| Preconditions | Є рахунок "Старий"                                                                           |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Видалити"<br>2. Підтвердити видалення                                          |
| Expected      | 1. Рахунок видалено зі списку<br>2. Відповідні транзакції деактивовані                       |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC091

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC091                                                                                        |
| Description   | Скасування видалення рахунку                                                                 |
| Preconditions | Відкрито діалог підтвердження видалення                                                     |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Скасувати" у діалозі                                                          |
| Expected      | 1. Діалог закривається<br>2. Рахунок залишається у списку                                    |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

## Розділ "Категорії"

### Test Case: TC092

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC092                                                                                        |
| Description   | Перевірка початкового стану розділу "Категорії"                                              |
| Preconditions | Категорій немає                                                                              |
| Data          | -                                                                                            |
| Steps         | 1. Перейти у "Налаштування" → "Категорії"                                                    |
| Expected      | Відображається повідомлення "Категорій не знайдено" та кнопка "Додати категорію"             |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC093

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC093                                                                                        |
| Description   | Додавання нової категорії витрат                                                             |
| Preconditions | Відкрито форму додавання категорії                                                           |
| Data          | Назва: "Продукти"<br>Тип: Витрати                                                           |
| Steps         | 1. Заповнити поля<br>2. Натиснути "Зберегти"                                                 |
| Expected      | 1. Категорія додана до списку<br>2. Доступна для вибору при додаванні витрат                 |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC094

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC094                                                                                        |
| Description   | Додавання нової категорії доходів                                                            |
| Preconditions | Відкрито форму додавання категорії                                                           |
| Data          | Назва: "Зарплата"<br>Тип: Доходи                                                            |
| Steps         | 1. Заповнити поля<br>2. Натиснути "Зберегти"                                                 |
| Expected      | 1. Категорія додана до списку<br>2. Доступна для вибору при додаванні доходів                |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC095

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC095                                                                                        |
| Description   | Спроба додати категорію без назви                                                            |
| Preconditions | Відкрито форму додавання категорії                                                           |
| Data          | Назва: (порожнє)<br>Тип: Витрати                                                            |
| Steps         | 1. Залишити назву порожньою<br>2. Спробувати зберегти                                        |
| Expected      | 1. Помилка "Назва обов'язкова"<br>2. Форма не закривається                                  |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC096

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC096                                                                                        |
| Description   | Зміна типу існуючої категорії                                                                |
| Preconditions | Є категорія "Подарунки" (тип Витрати)                                                        |
| Data          | Новий тип: Доходи                                                                            |
| Steps         | 1. Відкрити редагування<br>2. Змінити тип<br>3. Зберегти                                     |
| Expected      | 1. Тип змінено у списку<br>2. Тепер доступна для доходів                                     |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC097

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC097                                                                                        |
| Description   | Видалення категорії без транзакцій                                                           |
| Preconditions | Є категорія "Книги" без пов'язаних транзакцій                                                |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Видалити"<br>2. Підтвердити                                                    |
| Expected      | Категорія видалена зі списку                                                                 |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC098

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC098                                                                                        |
| Description   | Спроба видалити категорію з транзакціями                                                     |
| Preconditions | Є категорія "Їжа" з пов'язаними транзакціями                                                |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Видалити"<br>2. Підтвердити                                                    |
| Expected      | 1. Попередження "Ця категорія використовується в транзакціях"<br>2. Видалення неможливе      |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC099

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC099                                                                                        |
| Description   | Перевірка унікальності назви категорії                                                       |
| Preconditions | Є категорія "Транспорт"                                                                      |
| Data          | Назва: "Транспорт"                                                                           |
| Steps         | 1. Спробувати додати категорію з існуючою назвою                                             |
| Expected      | Помилка "Категорія з такою назвою вже існує"                                                 |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

### Test Case: TC100

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC100                                                                                        |
| Description   | Перевірка сортування категорій                                                               |
| Preconditions | Є категорії: "Аптека", "Житло", "Зарплата", "Кава"                                           |
| Data          | -                                                                                            |
| Steps         | 1. Перейти у розділ "Категорії"                                                              |
| Expected      | Категорії відсортовані за алфавітом (Аптека, Житло, Зарплата, Кава)                          |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

# Topic: Історія

## Test Case: TC101

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC101                                                                                        |
| Description   | Перевірка початкового стану сторінки "Історія транзакцій"                                   |
| Preconditions | Транзакцій немає                                                                             |
| Data          | -                                                                                            |
| Steps         | 1. Перейти на сторінку "Історія транзакцій"                                                 |
| Expected      | Відображається повідомлення "Транзакцій не знайдено"                                        |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC102

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC102                                                                                        |
| Description   | Додавання транзакції витрат                                                                  |
| Preconditions | Є рахунок "Готівка" (1000 UAH), категорія "Продукти" (тип Витрати)                          |
| Data          | Рахунок: "Готівка"<br>Категорія: "Продукти"<br>Сума: 500 UAH                                |
| Steps         | 1. Додати транзакцію витрат<br>2. Перевірити сторінку "Історія"                              |
| Expected      | 1. Транзакція відображається червоним кольором<br>2. Правильні дані: рахунок, категорія, сума, дата |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC103

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC103                                                                                        |
| Description   | Додавання транзакції доходу                                                                  |
| Preconditions | Є рахунок "Банк" (500 UAH), категорія "Зарплата" (тип Доходи)                               |
| Data          | Рахунок: "Банк"<br>Категорія: "Зарплата"<br>Сума: 10000 UAH                                 |
| Steps         | 1. Додати транзакцію доходу<br>2. Перевірити сторінку "Історія"                              |
| Expected      | 1. Транзакція відображається синім кольором<br>2. Правильні дані: рахунок, категорія, сума, дата |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC104

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC104                                                                                        |
| Description   | Перевірка оновлення балансу після транзакції                                                |
| Preconditions | Рахунок "Готівка" (1000 UAH)                                                                 |
| Data          | Транзакція витрат: -300 UAH (категорія "Кафе")                                               |
| Steps         | 1. Додати транзакцію<br>2. Перевірити головну сторінку                                       |
| Expected      | 1. "Загалом" оновлено до 700 UAH<br>2. "Частка витрат" збільшилась<br>3. "Частка залишку" зменшилась |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC105

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC105                                                                                        |
| Description   | Спроба додати транзакцію без вибору рахунку                                                  |
| Preconditions | Відкрито форму додавання транзакції                                                          |
| Data          | Категорія: "Продукти"<br>Сума: 200                                                          |
| Steps         | 1. Не вибирати рахунок<br>2. Натиснути "Додати"                                              |
| Expected      | Помилка "Оберіть рахунок"                                                                    |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC106

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC106                                                                                        |
| Description   | Спроба додати транзакцію без вибору категорії                                                |
| Preconditions | Відкрито форму додавання транзакції                                                          |
| Data          | Рахунок: "Готівка"<br>Сума: 100                                                             |
| Steps         | 1. Не вибирати категорію<br>2. Натиснути "Додати"                                            |
| Expected      | Помилка "Оберіть категорію"                                                                  |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC107

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC107                                                                                        |
| Description   | Спроба додати транзакцію з нульовою сумою                                                    |
| Preconditions | Відкрито форму додавання транзакції                                                          |
| Data          | Рахунок: "Готівка"<br>Категорія: "Подарунок"<br>Сума: 0                                     |
| Steps         | 1. Ввести 0 у поле суми<br>2. Натиснути "Додати"                                             |
| Expected      | Помилка "Сума має бути більше 0"                                                             |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC108

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC108                                                                                        |
| Description   | Спроба додати транзакцію з сумою більшою за баланс рахунку                                   |
| Preconditions | Рахунок "Готівка" (500 UAH)                                                                  |
| Data          | Сума: 600 UAH                                                                                |
| Steps         | 1. Ввести суму > балансу<br>2. Натиснути "Додати"                                            |
| Expected      | Попередження "Недостатньо коштів на рахунку"                                                |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC109

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC109                                                                                        |
| Description   | Сортування транзакцій за датою                                                               |
| Preconditions | Є 3 транзакції з різними датами                                                              |
| Data          | -                                                                                            |
| Steps         | 1. Перейти на сторінку "Історія"                                                             |
| Expected      | Транзакції відсортовані за датою (новіші зверху)                                             |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC110

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC110                                                                                        |
| Description   | Фільтрація транзакцій за типом (доходи/витрати)                                             |
| Preconditions | Є транзакції обох типів                                                                      |
| Data          | -                                                                                            |
| Steps         | 1. Увімкнути фільтр "Доходи"<br>2. Перевірити список                                        |
| Expected      | Відображаються лише транзакції доходу                                                       |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC111

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC111                                                                                        |
| Description   | Фільтрація транзакцій за рахунком                                                           |
| Preconditions | Є транзакції по різним рахункам                                                             |
| Data          | Рахунок: "Готівка"                                                                           |
| Steps         | 1. Обрати фільтр "Готівка"<br>2. Перевірити список                                          |
| Expected      | Відображаються лише транзакції по обраному рахунку                                          |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC112

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC112                                                                                        |
| Description   | Фільтрація транзакцій за періодом                                                           |
| Preconditions | Є транзакції за останній місяць                                                              |
| Data          | Період: поточний тиждень                                                                     |
| Steps         | 1. Встановити фільтр за датами тижня<br>2. Перевірити список                                |
| Expected      | Відображаються лише транзакції за обраний період                                            |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC113

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC113                                                                                        |
| Description   | Перевірка відображення транзакцій у різних валютах                                           |
| Preconditions | Є транзакції в UAH, USD                                                                      |
| Data          | -                                                                                            |
| Steps         | 1. Перейти на сторінку "Історія"                                                             |
| Expected      | Кожна транзакція відображає валюту                                                          |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC114

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC114                                                                                        |
| Description   | Перевірка формату відображення дати транзакції                                               |
| Preconditions | Є транзакція від 15.03.2023                                                                 |
| Data          | -                                                                                            |
| Steps         | 1. Перевірити формат дати у списку                                                           |
| Expected      | Дата у форматі "15 бер 2023" або іншому зручному                                             |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC115

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC115                                                                                        |
| Description   | Перевірка відображення транзакції після зміни назви рахунку                                  |
| Preconditions | Транзакція з рахунком "Готівка" (назву змінено на "Готівка UAH")                            |
| Data          | -                                                                                            |
| Steps         | 1. Змінити назву рахунку<br>2. Перевірити транзакцію в історії                              |
| Expected      | Відображається актуальна назва рахунку                                                      |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC116

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC116                                                                                        |
| Description   | Редагування суми транзакції                                                                  |
| Preconditions | Є транзакція витрат "Кафе" на 200 UAH                                                        |
| Data          | Нова сума: 250 UAH                                                                           |
| Steps         | 1. Натиснути "Редагувати"<br>2. Змінити суму<br>3. Зберегти                                  |
| Expected      | 1. Сума оновлена у списку<br>2. Баланс рахунку перераховано<br>3. Зміни відображаються на головній сторінці |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC117

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC117                                                                                        |
| Description   | Редагування категорії транзакції                                                             |
| Preconditions | Є транзакція "Продукти" (тип Витрати)                                                        |
| Data          | Нова категорія: "Ресторани" (тип Витрати)                                                    |
| Steps         | 1. Відкрити редагування<br>2. Змінити категорію<br>3. Зберегти                               |
| Expected      | 1. Категорія оновлена у списку<br>2. Статистика на головній оновлена                         |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC118

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC118                                                                                        |
| Description   | Зміна типу транзакції з витрат на дохід                                                      |
| Preconditions | Є транзакція "Подарунок" (тип Витрати)                                                       |
| Data          | Новий тип: Доходи, категорія "Подарунок"                                                     |
| Steps         | 1. Відкрити редагування<br>2. Змінити тип<br>3. Обрати відповідну категорію<br>4. Зберегти   |
| Expected      | 1. Транзакція змінена на дохід<br>2. Кольорова індикація змінена на синю<br>3. Баланси оновлено |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC119

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC119                                                                                        |
| Description   | Спроба зберегти редагування з нульовою сумою                                                 |
| Preconditions | Відкрито форму редагування транзакції                                                        |
| Data          | Сума: 0                                                                                      |
| Steps         | 1. Встановити 0<br>2. Спробувати зберегти                                                    |
| Expected      | Помилка "Сума має бути більше 0"                                                             |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC120

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC120                                                                                        |
| Description   | Видалення транзакції витрат                                                                  |
| Preconditions | Є транзакція "Комунальні" на 1500 UAH                                                        |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Видалити"<br>2. Підтвердити                                                    |
| Expected      | 1. Транзакція видалена з історії<br>2. Баланс рахунку збільшено на 1500 UAH<br>3. Статистика оновлена |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC121

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC121                                                                                        |
| Description   | Видалення транзакції доходу                                                                  |
| Preconditions | Є транзакція "Зарплата" на 10000 UAH                                                         |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Видалити"<br>2. Підтвердити                                                    |
| Expected      | 1. Транзакція видалена з історії<br>2. Баланс рахунку зменшено на 10000 UAH<br>3. Статистика оновлена |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC122

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC122                                                                                        |
| Description   | Скасування видалення транзакції                                                              |
| Preconditions | Відкрито діалог підтвердження видалення                                                      |
| Data          | -                                                                                            |
| Steps         | 1. Натиснути "Скасувати"                                                                     |
| Expected      | 1. Діалог закрито<br>2. Транзакція залишається у списку                                      |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC123

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC123                                                                                        |
| Description   | Редагування транзакції зі зміною рахунку                                                     |
| Preconditions | Є 2 рахунки: "Готівка" (1000 UAH), "Карта" (5000 UAH)<br>Транзакція на "Готівці" (-300 UAH)  |
| Data          | Новий рахунок: "Карта"                                                                       |
| Steps         | 1. Відкрити редагування<br>2. Змінити рахунок<br>3. Зберегти                                 |
| Expected      | 1. Баланс "Готівки" +300 UAH<br>2. Баланс "Карти" -300 UAH<br>3. Транзакція прив'язана до нового рахунку |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC124

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC124                                                                                        |
| Description   | Спроба редагування транзакції з видаленим рахунком                                           |
| Preconditions | Транзакція прив'язана до рахунку, який був видалений                                         |
| Data          | -                                                                                            |
| Steps         | 1. Спробувати відкрити редагування                                                           |
| Expected      | Повідомлення "Рахунок недоступний" з можливістю обрати інший рахунок                        |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC125

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC125                                                                                        |
| Description   | Редагування дати транзакції                                                                  |
| Preconditions | Є транзакція від 01.03.2023                                                                  |
| Data          | Нова дата: 15.03.2023                                                                        |
| Steps         | 1. Відкрити редагування<br>2. Змінити дату<br>3. Зберегти                                    |
| Expected      | 1. Транзакція зміщена у списку за новою датою<br>2. Фільтри за датою працюють коректно       |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC126

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC126                                                                                        |
| Description   | Масове видалення транзакцій                                                                  |
| Preconditions | Відібрано 3 транзакції через bulk-селект                                                     |
| Data          | -                                                                                            |
| Steps         | 1. Обрати транзакції<br>2. Натиснути "Видалити"<br>3. Підтвердити                            |
| Expected      | 1. Всі обрані транзакції видалені<br>2. Баланси коректно перераховані<br>3. Статистика оновлена |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC127

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC127                                                                                        |
| Description   | Перевірка відображення кнопок редагування/видалення для різних типів транзакцій             |
| Preconditions | Є транзакції доходу та витрат                                                                |
| Data          | -                                                                                            |
| Steps         | 1. Перевірити кнопки для доходу<br>2. Перевірити кнопки для витрат                           |
| Expected      | Кнопки однакові за стилем та розміщенням для обох типів                                      |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

---

## Test Case: TC128

| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC128                                                                                        |
| Description   | Доступність функціоналу редагування при відсутньому інтернеті                                |
| Preconditions | Вимкнено інтернет-з'єднання                                                                  |
| Data          | -                                                                                            |
| Steps         | 1. Спробувати відкрити редагування                                                           |
| Expected      | Повідомлення "Офлайн-режим: зміни синхронізуються при відновленні з'єднання"                 |
| Actual        | Відповідає очікуванню                                                                       |
| Status        | Pass                                                                                         |

# Topic: Сторінка "Доходи"

### Test Case: TC141
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC141                                                                                        |
| Description   | Перевірка відображення сторінки "Доходи" без транзакцій                                      |
| Preconditions | Немає жодних транзакцій доходу                                                               |
| Steps         | 1. Перейти на сторінку "Доходи"                                                              |
| Expected      | Відображається лише заголовок "Підсумок", без даних і розподілу за категоріями               |
| Status        | Pass                                                                                         |

---

### Test Case: TC142
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC142                                                                                        |
| Description   | Перевірка відображення одного доходу в одній валюті (USD)                                    |
| Preconditions | Є 1 транзакція доходу: категорія "Зарплата", сума 5000 USD                                   |
| Steps         | 1. Перейти на сторінку "Доходи"                                                              |
| Expected      | **Підсумок:**<br>- USD: 5000<br>**Розподіл:**<br>- Зарплата: 5000 USD                        |
| Status        | Pass                                                                                         |

---

### Test Case: TC143
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC143                                                                                        |
| Description   | Перевірка агрегації кількох доходів в одній валюті (UAH)                                    |
| Preconditions | Транзакції:<br>- "Фріланс": 15000 UAH<br>- "Інвестиції": 5000 UAH                           |
| Steps         | 1. Перейти на сторінку "Доходи"                                                              |
| Expected      | **Підсумок:**<br>- UAH: 20000<br>**Розподіл:**<br>- Фріланс: 15000 UAH<br>- Інвестиції: 5000 UAH |
| Status        | Pass                                                                                         |

---

### Test Case: TC144
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC144                                                                                        |
| Description   | Перевірка доходів у різних валютах (UAH, USD, EUR)                                          |
| Preconditions | Транзакції:<br>- "Зарплата": 20000 UAH<br>- "Дивіденди": 500 USD<br>- "Оренда": 1200 EUR    |
| Steps         | 1. Перейти на сторінку "Доходи"                                                              |
| Expected      | **Підсумок:**<br>- UAH: 20000<br>- USD: 500<br>- EUR: 1200<br>**Розподіл:**<br>Для кожної валюти окремий блок з категоріями |
| Status        | Pass                                                                                         |

---

### Test Case: TC145
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC145                                                                                        |
| Description   | Перевірка ігнорування витрат на сторінці "Доходи"                                           |
| Preconditions | Є транзакція витрат "Продукти" на 500 UAH                                                   |
| Steps         | 1. Перейти на сторінку "Доходи"                                                              |
| Expected      | Не відображається жодних даних (окрім заголовка "Підсумок", якщо доходів немає)              |
| Status        | Pass                                                                                         |

# Topic: Сторінка "Витрати"

### Test Case: TC146
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC146                                                                                        |
| Description   | Перевірка відображення сторінки "Витрати" без транзакцій                                     |
| Preconditions | Немає жодних транзакцій витрат                                                               |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | Відображається лише заголовок "Підсумок", без даних і розподілу за категоріями               |
| Status        | Pass                                                                                         |

---

### Test Case: TC147
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC147                                                                                        |
| Description   | Перевірка відображення однієї витрати в одній валюті (EUR)                                   |
| Preconditions | Є 1 транзакція витрат: категорія "Подорожі", сума 800 EUR                                    |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | **Підсумок:**<br>- EUR: 800<br>**Розподіл:**<br>- Подорожі: 800 EUR                          |
| Status        | Pass                                                                                         |

---

### Test Case: TC148
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC148                                                                                        |
| Description   | Перевірка агрегації витрат у різних категоріях (UAH)                                         |
| Preconditions | Транзакції:<br>- "Продукти": 1500 UAH<br>- "Комуналка": 3200 UAH<br>- "Транспорт": 700 UAH  |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | **Підсумок:**<br>- UAH: 5400<br>**Розподіл:**<br>- Продукти: 1500 UAH<br>- Комуналка: 3200 UAH<br>- Транспорт: 700 UAH |
| Status        | Pass                                                                                         |

---

### Test Case: TC149
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC149                                                                                        |
| Description   | Перевірка витрат у різних валютах з однаковими категоріями                                   |
| Preconditions | Транзакції:<br>- "Ресторани": 1200 UAH<br>- "Ресторани": 50 USD<br>- "Ресторани": 100 EUR   |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | **Підсумок:**<br>- UAH: 1200<br>- USD: 50<br>- EUR: 100<br>**Розподіл:**<br>Для кожної валюти окремий блок з категорією "Ресторани" |
| Status        | Pass                                                                                         |

---

### Test Case: TC150
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC150                                                                                        |
| Description   | Перевірка ігнорування доходів на сторінці "Витрати"                                          |
| Preconditions | Є транзакція доходу "Бонус" на 1000 UAH                                                     |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | Не відображається жодних даних (окрім заголовка "Підсумок", якщо витрат немає)               |
| Status        | Pass                                                                                         |

---

### Test Case: TC151
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC151                                                                                        |
| Description   | Перевірка форматування великих сум (1 000 000 UAH)                                           |
| Preconditions | Є транзакція витрат "Нерухомість" на 1000000 UAH                                            |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | Відображається "1 000 000 UAH" (з роздільником тисяч)                                        |
| Status        | Pass                                                                                         |

---

### Test Case: TC152
| Field         | Details                                                                                      |
| ------------- | -------------------------------------------------------------------------------------------- |
| ID            | TC152                                                                                        |
| Description   | Перевірка відображення дробових сум (BTC)                                                    |
| Preconditions | Є транзакція витрат "Інвестиції" на 0.005 BTC                                               |
| Steps         | 1. Перейти на сторінку "Витрати"                                                             |
| Expected      | Відображається "0.005 BTC" (з точністю до 3 знаків після коми)                              |
| Status        | Pass                                                                                         |
