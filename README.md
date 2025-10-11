# .NET Microservices Architecture with gRPC, RabbitMQ, Docker & Kubernetes

### A Production-Ready Distributed System Built with .NET 8, gRPC, and K8s

![Docker](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=white)
![Kubernetes](https://img.shields.io/badge/Kubernetes-326CE5?logo=kubernetes&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-FF6600?logo=rabbitmq&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green.svg)

---

## 🚀 Overview

This project demonstrates a **cloud-native microservices architecture** built with **.NET 9**.  
It showcases **inter-service communication**, **asynchronous messaging**, and **container orchestration** using **Docker** and **Kubernetes**.

Each microservice is fully decoupled, independently deployable, and communicates via both **REST** and **gRPC**, while **RabbitMQ** handles background event processing.

---

## 🧩 Tech Stack

- **.NET 9** – Core framework for building microservices  
- **gRPC** – High-performance inter-service communication  
- **RabbitMQ** – Message broker for asynchronous communication  
- **SQL Server** – Persistent data storage  
- **Docker & Docker Compose** – Containerization and local orchestration  
- **Kubernetes (K8s)** – Deployment, scaling, and service orchestration  
- **Nginx Ingress Controller** – Smart routing for internal/external traffic  

---

## 🏗️ Architecture

## ⚙️ Microservices

| Service | Description | Port |
|----------|--------------|------|
| **Platforms Service** | Manages platform data and publishes messages to RabbitMQ | `80`, `666` (gRPC) |
| **Commands Service** | Subscribes to RabbitMQ messages and executes commands logic | `80` |
| **RabbitMQ** | Handles inter-service message queues | `5672`, `15672` |
| **SQL Server** | Persistent data storage | `1433` |

---

## 🧰 Local Development (Docker)

```bash
# Clone the repo
git clone https://github.com/UgohP/dotnet-microservices-architecture.git
cd dotnet-microservices-architecture

# Build and run all containers
docker-compose up --build
```

# Once up, access the services:

Platforms API → http://localhost:8080/api/platforms

Commands API → http://localhost:8081/api/c/platforms

RabbitMQ Dashboard → http://localhost:15672

(default login: guest / guest)

# ☸️ Kubernetes Deployment

To deploy on Kubernetes:
```bash
kubectl apply -f k8s/
```

Check your resources:
```bash
kubectl get pods
kubectl get svc
kubectl get ingress
```

Once deployed, access via Ingress:

http://micro.com/api/platforms
http://micro.com/api/c/platforms


Ensure you map micro.com to 127.0.0.1 in your local /etc/hosts.