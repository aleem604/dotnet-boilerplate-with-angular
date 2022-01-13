const ENV = {
  dev: {
    apiUrl: 'http://localhost:44364',
    oAuthConfig: {
      issuer: 'http://localhost:44364',
      clientId: 'AngularBoilerplate_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access AngularBoilerplate',
    },
    localization: {
      defaultResourceName: 'AngularBoilerplate',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44364',
    oAuthConfig: {
      issuer: 'http://localhost:44364',
      clientId: 'AngularBoilerplate_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access AngularBoilerplate',
    },
    localization: {
      defaultResourceName: 'AngularBoilerplate',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
