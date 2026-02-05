# 1. Aşama: React uygulamasını build al
FROM node:20-alpine as build
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build

# 2. Aşama: Nginx ile sun
FROM nginx:alpine
# Build edilen dosyaları Nginx'in html klasörüne at
COPY --from=build /app/dist /usr/share/nginx/html
# React Router için gerekli Nginx ayarı (Opsiyonel ama önerilir)
COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]