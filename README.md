# Trekster
Simple financial tracker created to solve all your finance-related problems

Task board -> <a href="https://github.com/users/yvoznyak/projects/4">here</a>


CI/CD Pipeline Documentation for Trekster
This document outlines the Continuous Integration (CI) and Continuous Deployment (CD) process used in the Trekster project, implemented via GitHub Actions.

🔧 CI: Build & Test Workflow
Triggered on:
Push to main

Pull requests targeting main

Steps Overview:
Checkout the code

Setup .NET SDK

Install EF Core CLI

Restore project dependencies

Build the solution

Spin up PostgreSQL container

Wait for PostgreSQL readiness

Apply EF Core migrations

Install code analysis tools: Coverlet & SonarScanner

Run SonarCloud analysis

Run tests with coverage reports

Run additional integration/unit tests (excluding UI)

Publish app

Upload publish artifact

Start ASP.NET Core app locally

Health check via curl

Install Google Chrome for UI tests

Restore and run Selenium UI tests

🚀 CD: Deploy Workflow
Triggered after: build-and-test job is successful
Steps:
Download the published artifact

Login to Azure using service principal credentials

Deploy to Azure Web App

Target app name: trekster-app

Deployment slot: stage

🌐 Blue-Green Deployment Strategy
This project uses the Blue-Green Deployment strategy by leveraging Azure Web App Deployment Slots:

The application is deployed to the stage slot first (green environment).

After validation, traffic can be swapped to production slot (blue environment) via manual or automated slot swap.

This approach minimizes downtime and allows for quick rollback in case of failure.
