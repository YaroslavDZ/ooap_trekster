# Trekster
Simple financial tracker created to solve all your finance-related problems

Task board -> <a href="https://github.com/users/yvoznyak/projects/4">here</a>

# CI/CD Pipeline Documentation for Trekster

This document outlines the Continuous Integration (CI) and Continuous Deployment (CD) process used in the Trekster project, implemented via GitHub Actions.

---

## 🔧 CI: Build & Test Workflow

### Triggered on:
- Push to `main`
- Pull requests targeting `main`

### Steps Overview:
1. **Checkout the code**
2. **Setup .NET SDK**
3. **Install EF Core CLI**
4. **Restore project dependencies**
5. **Build the solution**
6. **Spin up PostgreSQL container**
7. **Wait for PostgreSQL readiness**
8. **Apply EF Core migrations**
9. **Install code analysis tools: Coverlet & SonarScanner**
10. **Run SonarCloud analysis**
11. **Run tests with coverage reports**
12. **Run additional integration/unit tests (excluding UI)**
13. **Publish app**
14. **Upload publish artifact**
15. **Start ASP.NET Core app locally**
16. **Health check via `curl`**
17. **Install Google Chrome for UI tests**
18. **Restore and run Selenium UI tests**

---

## 🚀 CD: Deploy Workflow

### Triggered after: `build-and-test` job is successful

### Steps:
1. **Download the published artifact**
2. **Login to Azure using service principal credentials**
3. **Deploy to Azure Web App**  
   - Target app name: `trekster-app`  
   - **Deployment slot:** `stage`

---

## 🌐 Blue-Green Deployment Strategy

This project uses the **Blue-Green Deployment** strategy by leveraging **Azure Web App Deployment Slots**:

- The application is deployed to the `stage` slot first (green environment).
- After validation, traffic can be swapped to production slot (`blue` environment) via manual slot swap.
- This approach minimizes downtime and allows for quick rollback in case of failure.
