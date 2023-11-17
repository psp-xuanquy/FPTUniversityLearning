import RightContent from '@/components/RightContent';
import type { Settings as LayoutSettings } from '@ant-design/pro-components';
import type { RunTimeLayoutConfig } from '@umijs/max';
import { history } from '@umijs/max';
import 'antd/dist/antd.css';
import defaultSettings from '../config/defaultSettings';
import UnPermission from './pages/403';
import NoFoundPage from './pages/404';
// import { errorConfig } from './requestErrorConfig';
import WebSocketProvider from './pages/WebSocketProvider';
import { getInfo } from './services/api/UserController';

const isDev = process.env.NODE_ENV === 'development';
const loginPath = '/login';
const verifyEmail = '/auth/verify/email';
const resetPassword = '/reset-password';
const reActive = '/re-active';
const forgotPassword = '/forgot-password';
const reVerifyEmail = '/auth/verify/re-active';

/**
 * @see  https://umijs.org/zh-CN/plugins/plugin-initial-state
 * */
export async function getInitialState(): Promise<{
  settings?: Partial<LayoutSettings>;
  currentUser?: API.UserResponse;
  loading?: boolean;
  isLogined?: boolean;
  fetchUserInfo?: () => Promise<API.UserResponse | undefined>;
}> {
  const fetchUserInfo = async () => {
    try {
      const msg = await getInfo({
        skipErrorHandler: true,
      });
      return msg?.data;
    } catch (error) {
      history.push(loginPath);
    }
    return undefined;
  };
  // 如果不是登录页面，执行
  const { location } = history;
  if (
    location.pathname !== loginPath &&
    location.pathname !== verifyEmail &&
    location.pathname !== resetPassword &&
    location.pathname !== reActive &&
    location.pathname !== forgotPassword &&
    location.pathname !== reVerifyEmail
  ) {
    const currentUser = await fetchUserInfo();
    return {
      fetchUserInfo,
      currentUser,
      isLogined: true,
      settings: defaultSettings,
    };
  }
  return {
    fetchUserInfo,
    settings: defaultSettings,
  };
}

// ProLayout 支持的api https://procomponents.ant.design/components/layout
export const layout: RunTimeLayoutConfig = ({ initialState, setInitialState }) => {
  return {
    rightContentRender: () => <RightContent />,
    waterMarkProps: {
      content: `${initialState?.currentUser?.firstName} ${initialState?.currentUser?.lastName}`,
    },
    // footerRender: () => <Footer />,
    onPageChange: () => {
      const { location } = history;
      if (location.pathname === verifyEmail) {
      } else if (location.pathname === resetPassword) {
      } else if (location.pathname === reActive) {
      } else if (location.pathname === forgotPassword) {
      } else if (location.pathname === reVerifyEmail) {
      }
      // 如果没有登录，重定向到 login
      else if (!initialState?.currentUser && location.pathname !== loginPath) {
        history.push(loginPath);
      }
      // em chua mow
    },
    layoutBgImgList: [
      {
        src: 'https://mdn.alipayobjects.com/yuyan_qk0oxh/afts/img/D2LWSqNny4sAAAAAAAAAAAAAFl94AQBr',
        left: 85,
        bottom: 100,
        height: '303px',
      },
      {
        src: 'https://mdn.alipayobjects.com/yuyan_qk0oxh/afts/img/C2TWRpJpiC0AAAAAAAAAAAAAFl94AQBr',
        bottom: -68,
        right: -45,
        height: '303px',
      },
      {
        src: 'https://mdn.alipayobjects.com/yuyan_qk0oxh/afts/img/F6vSTbj8KpYAAAAAAAAAAAAAFl94AQBr',
        bottom: 0,
        left: 0,
        width: '331px',
      },
    ],
    links: isDev ? [] : [],
    menuHeaderRender: undefined,
    // 自定义 403 页面
    // unAccessible: <div>unAccessible</div>,
    // 增加一个 loading 的状态
    childrenRender: (children, props) => {
      // if (initialState?.loading) return <PageLoading />;
      return (
        <>
          <WebSocketProvider>{children}</WebSocketProvider>
        </>
      );
    },
    ...initialState?.settings,
    unAccessible: <UnPermission />,
    noFound: <NoFoundPage />,
  };
};

/**
 * @name request 配置，可以配置错误处理
 * 它基于 axios 和 ahooks 的 useRequest 提供了一套统一的网络请求和错误处理方案。
 * @doc https://umijs.org/docs/max/request#配置
 */
// export const request = {
//   ...errorConfig,
// };
