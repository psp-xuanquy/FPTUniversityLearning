import { history } from '@umijs/max';
import { useEffect } from 'react';
import { verifyReActive } from '@/services/api/AuthController';
import { message } from 'antd';

const ReVerifyEmail: React.FC = () => {
  let location = history.location;
  const token = new URLSearchParams(location.search).get('token');
  const email = new URLSearchParams(location.search).get('email');
  const verify = async (params: API.verifyReActiveParams) => {
    const res = await verifyReActive(params);
    if (res?.code === 0) {
      message.success('Verify success');
    } else {
      message.error(`${res?.message}`);
    }
    history.push('/login');
  };
  useEffect(() => {
    console.log(token);
    console.log(email);
    console.log('verify email');

    verify({ token: token || '', email: email || '' });
  }, []);
  return <></>;
};

export default ReVerifyEmail;
