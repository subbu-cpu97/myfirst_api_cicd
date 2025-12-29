variable "env_id" {
    description = "Environment ID"
    type        = string
    default     = "dev"
}

variable "src_key" {
    description = "Source Key"
    type        = string
    default     = "terraform"
  
}

variable "subscription_id" {
    description = "Azure Subscription ID"
    type        = string
    default     = "e31e2228-c33e-47fe-bd12-8b50271caf71"
  
}

variable "sql_admin_user" {
    description = "Azure Sql Server Admin"
    type = string
    default = "f1sadmin"
}

variable "sql_admin_password" {
    description = "Azure Sql Server Admin Password"
    type = string
    default = "Admin@12345"
}