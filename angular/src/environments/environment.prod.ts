import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AngularBoilerplate',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44364',
    redirectUri: baseUrl,
    clientId: 'AngularBoilerplate_App',
    responseType: 'code',
    scope: 'offline_access AngularBoilerplate',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44364',
      rootNamespace: 'AngularBoilerplate',
    },
  },
} as Environment;
